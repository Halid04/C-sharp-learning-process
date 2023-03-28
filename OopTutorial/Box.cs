using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTutorial
{
    internal class Box
    {
        private int lunghezza;
        private int altezza;
        private int larghezza;
        private int volume;

        public Box(int lunghezza, int altezza, int larghezza)
        {
            this.lunghezza = lunghezza;
            this.altezza = altezza;
            this.larghezza = larghezza;
        }

        public Box() { }

        public void SetLunghezza(int lunghezza)
        {
            this.lunghezza = lunghezza;
        }
        public int GetLunghezza()
        {
            return this.lunghezza;
        }

        public void SetAltezza(int altezza)
        {
            this.altezza = altezza;
        }
        public int GetAltezza()
        {
            return this.altezza;
        }

        public void SetLarghezza(int larghezza)
        {
            this.larghezza = larghezza;
        }
        public int GetLarghezza()
        {
            return this.larghezza;
        }

        public int GetVolume()
        {
            return this.larghezza * this.altezza * this.lunghezza;
        }

        public void BoxInfo()
        {
            Console.WriteLine("lunghezza: {0}, altezza: {1}, larghezza: {2}, volume: {3}", 
                lunghezza,altezza,larghezza,GetVolume());
        }
    }
}
