using System;


namespace PaintballGun;
class Program
{
    static void Main(string[] args)
    {
        PaintballGun gun = new PaintballGun();
        while(true)
        {
            Console.WriteLine($"{gun.Balls} balls, {gun.Ba} loaded");
            if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo");
            Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
            char key = Console.ReadKey(true).KeyChar;
            if (key == ' ') Console.WriteLine($"Shoting returned {gun.Shoot()}");
            else if (key == 'r') gun.Reload();
            else if (key == '+') gun.Balls += gun.MagazineSize;
            else if (key == 'q') return;



        }



    }


}