using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramids
{
    class Pyramid
    {
        public int LayersOfPyramid { get; private set; }
        public string ShapeOfPyramid { get; private set; }

        public Pyramid(int layersOfPyramid, string shapeOfPyramid)
        {
            LayersOfPyramid = layersOfPyramid;
            ShapeOfPyramid = shapeOfPyramid;
        }

        public string createPyramidRight(int layers)
        {
            string answerPyramid = "";
            int layersOfPyramid = layers;
            for (int i = 0; i < layersOfPyramid; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    answerPyramid += "*";
                }
                answerPyramid += "\r\n";
            }
            return answerPyramid;
        }

        public string createPyramidCenter(int layers)
        {
            string answerPyramid = "";
            int layersOfPyramid = layers;
            for (int i = 0; i < layersOfPyramid; i++)
            {
                for (int j = layersOfPyramid - 1; j > i; j--)
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

        public string createPyramidReverse(int layers)
        {
            string answerPyramid = "";
            int layersOfPyramid = layers;
            for (int i = 0; i < layersOfPyramid; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    answerPyramid += " ";
                }

                for (int j = 2 * layersOfPyramid - 1; j > 2 * i; j--)
                {
                    answerPyramid += "*";
                }

                answerPyramid += "\r\n";
            }
            return answerPyramid;
        }
    }
}
