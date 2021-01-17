using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeekInTheHouse
{
    public partial class Form1 : Form
    {
        int moves;
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedRoom;
        RoomWithHidingPlace secondBedRoom;

        OutsideWithHidingPlace garden;
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            createObjects();
            opponent = new Opponent(frontYard);
            resetGame(false);
        }


        private void createObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "inside the closet");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door", "in the cabinet");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedRoom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedRoom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRoom.exits = new Location[] { livingRoom, kitchen };
            livingRoom.exits = new Location[] { diningRoom };
            kitchen.exits = new Location[] { diningRoom };
            stairs.exits = new Location[] { livingRoom, hallway };
            hallway.exits = new Location[] { stairs, bathroom, masterBedRoom, secondBedRoom };
            bathroom.exits = new Location[] { hallway };
            masterBedRoom.exits = new Location[] { hallway };
            secondBedRoom.exits = new Location[] { hallway };
           
            frontYard.exits = new Location[] { backYard, garden, driveway };
            backYard.exits = new Location[] { frontYard, garden, driveway };
            garden.exits = new Location[] { backYard, frontYard };
            driveway.exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void moveToANewLocation( Location newLocation)
        {
            moves++;
            currentLocation = newLocation;
            redrawForm();
        }

        private void resetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + moves + " moves! He was hiding " + foundLocation.HidingPlaceName + ".";
            }
            moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void redrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.exits.Length; i++)
            {
                exits.Items.Add(currentLocation.exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(move #" + moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            moveToANewLocation(currentLocation.exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            moveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            moves++;
            if (opponent.check(currentLocation))
                resetGame(true);
            else
                redrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 0; i <= 10; i++)
            {
                opponent.move();
                description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            moveToANewLocation(livingRoom);
        }
    }
}
