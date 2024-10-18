using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Weapon
    {
        public string name; 
        private int _magazineCapacity;
        private int _magazine;
        private bool _fireType;

        public int MagazineCapacity 
        {
            get
            {
                return _magazineCapacity;
            }
            set
            {
                if(value> 0)
                {
                    _magazineCapacity = value;
                }
            }
        }
        public int Magazine
        {
            get
            {
                return _magazine;
            }
            set
            {
                if (value <= MagazineCapacity)
                {
                    _magazine = value;
                }
            }
        }

        public bool FireType
        {
            get
            {
                return _fireType;
            }
            set
            {
                _fireType = value;
            }
        }
        public Weapon(string name, int magazineCapacity, int magazine, bool firetype)
        {
            MagazineCapacity = magazineCapacity;
            Magazine = magazine;
            FireType = firetype;
            this.name = name;   
        }

        public void Shoot()
        {
            if (Magazine > 0)
            {
                if (!FireType)
                {
                    Magazine--;
                }
                else
                {
                    Magazine = 0;
                }
                Console.WriteLine($"Ates acildi. \nSilahda {Magazine} sayda gulle qaldi");
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder gulle qalmiyib. xahis olunur balansinizi artirin)"); 
            }
        }
        public void changeCapacity(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Silahin gulle tutumu deyisdirilmedi");
            }
            else if (value == Magazine) {
                Console.WriteLine("Deyismek istediyiniz darag ile yeni darag eyni oldugu ucun deyisdirilmedi");
            }
            else
            {

                Console.WriteLine($"Silahin gulle tutumu {MagazineCapacity}-den {value}-a deyisdirildi");
                MagazineCapacity = value;
            }

        }
        public void changeMagazine(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Silahin gulle sayi deyisdirilmedi");
            }
            else if (value > Magazine)
            {
                Console.WriteLine("Bu gulle sayi daraga uygun deyil ");
            }
            else
            {

                Console.WriteLine($"Silahin gulle sayi {Magazine}-den {value}-a deyisdirildi");
                MagazineCapacity = value;
            }

        }
        public int GetRemainBulletCount()
        {
            return MagazineCapacity - Magazine; 
        }
        public void Reload()
        {
            Magazine = MagazineCapacity;
            Console.WriteLine("Gulle yeniden dolduruldu");
        }
        public void ChangeFireMode()
        {
            bool first = FireType;
            if (FireType)
            { 
                FireType = false;
                Console.WriteLine($"Atis modu avtomatik-den tekli moda deyisdirildi");
            }
            else
            {
                FireType = true;
                Console.WriteLine($"Atis modu tekli moddan avtomatik moda deyisdirildi");
            }
        }
        public void showFullInfo()
        {
            Console.WriteLine($"Name: {name} \nDaragin gulle tutumu: {MagazineCapacity} \nDaragda ki gulle sayi: {Magazine}");
            if (FireType)
            {
                Console.WriteLine("Silahin Atis modu: Avtomatik");
            }
            else 
            {
                Console.WriteLine("Silahin Atis modu: Tekli");
            }
        } 
    }
}
