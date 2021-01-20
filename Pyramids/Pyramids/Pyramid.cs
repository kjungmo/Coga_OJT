using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyramids
{
    class Pyramid
    {
        public int LayersOfPyramid { get; set; }
        public PyramidShape ShapeOfPyramid { get; set; }

        public Pyramid(int layersOfPyramid, PyramidShape shapeOfPyramid)
        {
            LayersOfPyramid = layersOfPyramid;
            ShapeOfPyramid = shapeOfPyramid;
        }

        public Pyramid()
        {

        }

        public string CreateStarPyramid()
        {

            if (ShapeOfPyramid == PyramidShape.Rightsided)
            {
                return CreatePyramidRight();
            }
            else if (ShapeOfPyramid == PyramidShape.Centered)
            {
                return CreatePyramidCenter();
            }
            else if (ShapeOfPyramid == PyramidShape.Reversed)
            {
                return CreatePyramidReverse();
            }
            else
                return CreatePyramidShape();
        }

        public string CreatePyramidRight()
        {
            string answerPyramid = "";
            for (int i = 0; i < LayersOfPyramid; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    answerPyramid += "*";
                }
                answerPyramid += "\r\n";
            }
            return answerPyramid;
        }

        public string CreatePyramidCenter()
        {
            string answerPyramid = "";
            for (int i = 0; i < LayersOfPyramid; i++)
            {
                for (int j = LayersOfPyramid - 1; j > i; j--)
                {
                    answerPyramid += " ";
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    answerPyramid += "*";
                }
                answerPyramid += "\r\n";
            }
            return answerPyramid;
        }

        public string CreatePyramidReverse()
        {
            string answerPyramid = "";
            for (int i = 0; i < LayersOfPyramid; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    answerPyramid += " ";
                }

                for (int j = 2 * LayersOfPyramid - 1; j > 2 * i; j--)
                {
                    answerPyramid += "*";
                }

                answerPyramid += "\r\n";
            }
            return answerPyramid;
        }

        public string CreatePyramidShape()
        {
            string answerPyramid = "";
            MessageBox.Show("Choose the shape!");
            return answerPyramid;
        }
    }
}
