using System.Collections.Generic;
using Cairo;

namespace ExportImportImages
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<List<string>> test = new List<List<string>>();
            test.Add(new List<string> { "1", "0", "1", "0", "1", "0" });
            test.Add(new List<string> { "0", "1", "0", "1", "0", "1" });
            test.Add(new List<string> { "1", "0", "1", "0", "1", "0" });
            test.Add(new List<string> { "0", "1", "0", "1", "0", "1" });
            test.Add(new List<string> { "1", "0", "1", "0", "1", "0" });
            test.Add(new List<string> { "0", "1", "0", "1", "0", "1" });


            // The using statement ensures that potentially heavy objects
            // are disposed immediately.
            using (ImageSurface draw = new ImageSurface(Format.Argb32, 6, 6))
            {

                using (Context gr = new Context(draw))
                {
                    gr.Antialias = Antialias.Subpixel;    // sets the anti-aliasing method

                    gr.Rectangle(0, 0, 6, 6);
                    gr.LineWidth = 4;          // sets the line width
                    gr.SetSourceColor(new Color(1, 1, 1, 1));   // red, green, blue, alpha
                    gr.Fill();

                    for (var row = 0; row < test.Count; row++)
                    {
                        for (var element = 0; element < test[0].Count; element++)
                        {
                            if (test[row][element] == "1")
                            {
                                gr.Rectangle(row, element, 1, 1);
                                gr.LineWidth = 1;          // sets the line width
                                gr.SetSourceColor(new Color(0, 0, 0, 1));   // red, green, blue, alpha
                                gr.Fill();
                            }
                        }
                    }

                    /*gr.Rectangle(0, 0, 50, 50);
                    gr.LineWidth = 4;          // sets the line width
                    gr.SetSourceColor(new Color(0, 1, 0, 1));   // red, green, blue, alpha
                    gr.Stroke();*/        //stroke the line to the image surface

                    draw.WriteToPng("antialias.png");  //save the image as a png image.

                    var imageFile = new ImageSurface("antialias.png");
                    var imageFileData = imageFile.Data;
                }

                Image image = new Image();
                image.ReadImageFile("antialias.png");
                var pixels = image.Pixels;
            }
        }
    }


    class Image
    {
        public int Width;
        public int Height;
        public List<Pixel> Pixels;

        public Image()
        {
        }


        public void CreateNewImage()
        {
        }

        public void SaveAsPNG(string path)
        {
        }


        public void ReadImageFile(string path)
        {
            var imageFile = new ImageSurface(path);

            Width = imageFile.Width;
            Height = imageFile.Height;
            var imageFileData = imageFile.Data;

            Pixels = new List<Pixel>();
            for (var element = 0; element < imageFileData.Length; element += 4)
            {
                Pixels.Add(new Pixel(imageFileData[element], imageFileData[element + 1], imageFileData[element + 2], imageFileData[element + 3]));
            }
        }
    }

    class Pixel
    {
        public int R { get; }
        public int G { get; }
        public int B { get; }
        public int A { get; }

        public Pixel(int R, int G, int B, int A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }
    }


}