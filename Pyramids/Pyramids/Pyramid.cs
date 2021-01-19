using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramids
{
    class Pyramid
    {
        public int LayersOfPyramid { get; set; }
        public string ShapeOfPyramid { get; set; }

        public Pyramid(int layersOfPyramid, string shapeOfPyramid)
        {
            LayersOfPyramid = layersOfPyramid;
            ShapeOfPyramid = shapeOfPyramid;
        }

        public string CreateStarPyramid()
        {

            if (ShapeOfPyramid == PyramidShape.Rightsided.ToString())
            {
                return CreatePyramidRight();
            }
            else if (ShapeOfPyramid == PyramidShape.Centered.ToString())
            {
                return CreatePyramidCenter();
            }
            else if (ShapeOfPyramid == PyramidShape.Reversed.ToString())
            {
                return CreatePyramidReverse();
            }
            else
                return " ";
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
    }
}
