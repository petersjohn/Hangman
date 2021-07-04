using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOs
{
    public class GallowsREPO
    {
        public void BuildGallows()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "      |\n" +
                "      |\n" +
                "      |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetHead()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                "      |\n" +
                "      |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetBody()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                "  |   |\n" +
                "      |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetLeftArm()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                " /|   |\n" +
                "      |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetRightArm()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                " /|`  |\n" +
                "      |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetLeftLeg()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                " /|`  |\n" +
                " /    |\n" +
                "      |\n" +
                "=========\n");
        }
        public void GetRightLeg()
        {
            Console.WriteLine(
                "  +---+\n" +
                "  |   |\n" +
                "  O   |\n" +
                " /|`  |\n" +
                " / L  |\n" +
                "      |\n" +
                "=========\n");
        }
    }
}
