// Name: Chiapco, Tatiana G.
// BSCS 1-1
// Date: May 13, 2022
// Width: 131
// Height: 42
// Topic: Cameras
// Final Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chiapco_Tatiana_G._BSCS_1_1_
{
    class Program
    {
        static string pa = "D:/CC3TermProject/";

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("Intro.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1: proceed(); break;
                    case 2: read_and_write(); break;
                    case 3: machine_mod(); break;
                }
            }
            while (choice != 0);
        }

        static void proceed()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("table.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: introduction(); break;
                    case 2: types_of_cam(); break;
                    case 3: function(); break;
                    case 4: parts_cam(); break;
                    case 5: timeline(); break;
                    case 6: accessories(); break;
                    case 7: about_me(); break;
                }
            }
            while (choice != 0);
        }

        static void read_and_write()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("read_and_write.txt");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0: break;
                    case 1: addrecord(); break;
                    case 2: display_rec(); break;
                }
            }
            while (choice != 0);
        }

        static void display_rec()
        {
            int choice;

            do
            {
                ReadText("data.txt");

                Console.WriteLine("\n\n\n\t\t\t[ 1 ] Create New Record \n\n\n");
                Console.WriteLine("\t\t\t[ 2 ] Display \n\n\n");
                Console.WriteLine("\t\t\t[ 0 ] Back \n\n\n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: addrecord(); break;
                    case 2: display_rec(); break;
                }
            } while (choice != 0);
        }

        static void addrecord()
        {
            string cosmetinum, types, brand, colorshade;
            int choice;
            do
            {
                Console.Clear();

                Console.Write("\n\t\t\t Enter a Cosmetic Number:");
                cosmetinum = Convert.ToString(Console.ReadLine());

                Console.WriteLine("{-----------------------------------------------------------------------------}");
                Console.Write("\n\t\t\t Enter Type of a Cosmetic: ");
                types = Convert.ToString(Console.ReadLine());

                Console.WriteLine("{-----------------------------------------------------------------------------}");
                Console.Write("\n\t\t\t Enter Cosmetic's Brand: ");
                brand = Convert.ToString(Console.ReadLine());

                Console.WriteLine("{-----------------------------------------------------------------------------}");
                Console.Write("\n\t\t\t Enter Color / Shade of the Cosmetic: ");
                colorshade = Convert.ToString(Console.ReadLine());

                cosmetinum = cosmetinum + "                           " + types + "                           " + brand + "                           " + colorshade;

                ReadwriteText("data.txt", cosmetinum);
                display_rec();

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: addrecord(); break;
                    case 2: display_rec(); break;
                }
            }
            while (choice != 0);
        }

        static void ReadwriteText(string pathx, string name)
        {
            string line = "";
            int i = 0;
            string[] names = new string[100];

            using (StreamReader sr = new StreamReader(pa + pathx))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    names[i] = line;
                    i++;
                    Console.WriteLine(line);
                }
            }
            names[i] = name;

            using (StreamWriter sw = new StreamWriter(pa + pathx))
            {
                for (int j = 0; j <= i; j++)
                {
                    sw.WriteLine(names[j]);
                }
            }
        }

        static void machine_mod()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("modules.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: module_1(); break;
                    case 2: module_2(); break;
                    case 3: module_3(); break;
                    case 4: module_4(); break;
                    case 5: module_5(); break;
                    case 6: module_6(); break;
                }
            }
            while (choice != 0);
        }

        static void introduction()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("what_is_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: proceed_1(); break;
                }
            }
            while (choice != 0);
        }

        static void proceed_1()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("what_is_cam_next.txt");
                choice = Convert.ToInt16(Console.ReadLine());
            }
            while (choice != 0);
        }

        static void types_of_cam()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("types_of_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: dslr_cam(); break;
                    case 2: mirrorless(); break;
                    case 3: point_shoot(); break;
                    case 4: smartphone(); break;
                    case 5: bridge(); break;
                    case 6: medium_form(); break;
                    case 7: film_cam(); break;
                    case 8: polaroid(); break;
                    case 9: digital_cine(); break;
                    case 10: action(); break;
                    case 11: degree_cam(); break;
                    case 12: rugged(); break;
                }
            }
            while (choice != 0);
        }

        static void dslr_cam()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("dslr_cams.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mirrorless()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("mless_cams.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }


        static void point_shoot()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("pandshoo_cams.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void smartphone()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("smartphone_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void bridge()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("bridge_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void medium_form()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("mformat_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void film_cam()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("film_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void polaroid()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("polaroid_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void digital_cine()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("digitalcine_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void action()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("action_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void degree_cam()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("360_deg_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void rugged()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("rugged_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void function()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("functions_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mode_dial(); break;
                    case 2: focus_stick(); break;
                    case 3: drive_butt(); break;
                    case 4: comm_dials(); break;
                    case 5: func_dial(); break;
                    case 6: indic_lamp(); break;
                    case 7: lcd_mon(); break;
                    case 8: foc_view(); break;
                }
            }
            while (choice != 0);
        }

        static void mode_dial()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("mode_dial.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void focus_stick()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("focus_stick.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void drive_butt()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("drive_button.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void comm_dials()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("command_dials.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void func_dial()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("func_dial.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void indic_lamp()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("indicator_lamp.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void lcd_mon()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("lcd_monitor.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void foc_view()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("viewfinder.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }
        static void parts_cam()

        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("parts_of_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: aperture(); break;
                    case 2: shutter(); break;
                    case 3: Image_sens(); break;
                    case 4: viewfinder(); break;
                    case 5: digital_lcd(); break;
                    case 6: button_inter(); break;
                    case 7: in_built_flash(); break;
                    case 8: shutter_trigg(); break;
                    case 9: mode_dial_2(); break;
                    case 10: hotshoe(); break;
                    case 11: commu_parts(); break;
                    case 12: recording_med(); break;
                    case 13: batt_compart(); break;
                    case 14: tripod_mount(); break;
                }
            }
            while (choice != 0);
        }

        static void aperture()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("aperture.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void shutter()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("shutter.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void Image_sens()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("image_sensor.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void viewfinder()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("viewfinder_2.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void digital_lcd()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("digital_lcd.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void button_inter()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("button_interface.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void in_built_flash()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("built_flash.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void shutter_trigg()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("shutter_trigg.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mode_dial_2()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("mode_dial_2.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void hotshoe()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("hotshoe.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void commu_parts()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("comm_parts.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void recording_med()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("recording_med.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void batt_compart()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("battery_compart.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void tripod_mount()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("tripod_mount.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("timeline_des.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: timeline_1(); break;
                    case 2: timeline_2(); break;
                    case 3: timeline_3(); break;
                    case 4: timeline_4(); break;
                    case 5: timeline_5(); break;
                    case 6: timeline_6(); break;
                    case 7: timeline_7(); break;
                    case 8: timeline_8(); break;
                    case 9: timeline_9(); break;
                    case 10: timeline_10(); break;
                    case 11: timeline_11(); break;
                    case 12: timeline_12(); break;
                    case 13: timeline_13(); break;
                    case 14: timeline_14(); break;
                    case 15: timeline_15(); break;
                    case 16: timeline_16(); break;
                    case 17: timeline_17(); break;
                    case 18: timeline_18(); break;
                    case 19: timeline_19(); break;
                    case 20: timeline_20(); break;
                }
            }
            while (choice != 0);
        }

        static void timeline_1()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1040_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_2()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1839_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_3()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1840_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_4()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1859_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_5()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1861_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_6()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1888_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_7()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1900_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_8()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1900_time_2.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_9()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1913_1914_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_10()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1929_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_11()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1933_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_12()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1948_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_13()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1960_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_14()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1978_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_15()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1981_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_16()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1986_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_17()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1991_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_18()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("1994_1996_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_19()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("2000_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void timeline_20()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("2005_time.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void accessories()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("accessories_cam.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void about_me()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("about_student.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: personal(); break;
                    case 2: hobbies(); break;
                    case 3: habits(); break;
                    case 4: thoughts(); break;
                    case 5: works(); break;
                    case 6: uniqueness(); break;
                }
            }
            while (choice != 0);
        }

        static void personal()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("personal_det.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void hobbies()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("hobbies.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void habits()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("everyday_habits.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void thoughts()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("thoughts.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void works()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("works.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void uniqueness()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("other_about.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);

        }
        static void module_1()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_1.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_1(); break;
                    case 2: mp_2(); break;
                    case 3: mp_3(); break;
                    case 4: mp_4(); break;
                    case 5: mp_5(); break;
                    case 6: mp_6(); break;
                    case 7: mp_7(); break;
                    case 8: mp_8(); break;
                    case 9: mp_9(); break;
                    case 10: mp_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_1()
        {
            int choice;

            double num1 = 4, num2 = 3, r = 0, r2 = 0, v = 0;
            const double P = 3.1415926536;

            do
            {
                Console.Write("Put a Number for Radius: ");

                r = Convert.ToInt32(Console.ReadLine());

                r2 = r * r * r;

                v = (num1 / num2) * P * r2;

                Console.WriteLine("The Value of the Sphere is: " + v);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2()
        {
            int choice;

            double num1 = 9, num2 = 5, num3 = 32, c = 0, f = 0;

            do
            {
                Console.Write("The Current Celcius is: ");

                c = Convert.ToInt32(Console.ReadLine());

                f = (num1 / num2) * c + num3;

                Console.WriteLine("The Current Fahrenheit is: " + f);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3()
        {
            int choice;

            double p = 0, d = 0;
            const double er = 53.95;

            do
            {
                Console.Write("Enter an Amount for US Dollar: ");

                d = Convert.ToInt32(Console.ReadLine());

                p = d * er;

                Console.WriteLine("Philippine Peso: " + p);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4()
        {
            int choice;

            double inc = 0, cent = 0;
            const double equiv = 2.54;


            do
            {
                Console.Write("Inches: ");

                inc = Convert.ToInt32(Console.ReadLine());

                cent = inc / equiv;

                Console.WriteLine("Centimeter: " + cent);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5()
        {
            int choice;

            int x = 0, y = 0, x1 = 0, y1 = 0;


            do
            {
                Console.Write("Value of x: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Value of y: ");
                y = Convert.ToInt32(Console.ReadLine());

                x1 = y;

                y1 = x;


                Console.WriteLine("\n Value of x: " + x1);
                Console.WriteLine("\n Value of y: " + y1);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6()
        {
            int choice;

            double num1 = 2, c = 0, r = 0;
            const double p = 3.1415926536;

            do
            {
                Console.Write("Enter Radius: ");
                r = Convert.ToInt32(Console.ReadLine());

                c = num1 * p * r;

                Console.WriteLine("The Circumference of the Cirle is: " + c);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_7()
        {
            int choice;

            int x = 0, y = 0, x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0;


            do
            {
                Console.Write("Value for x: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Value for y: ");
                y = Convert.ToInt32(Console.ReadLine());

                x1 = y;

                y1 = x;

                x2 = x1 + y1;

                y2 = y1 - x1 + y1;

                x3 = y1 + x1 + y1 - x1;


                Console.WriteLine("First: " + x2);
                Console.WriteLine("Second: " + y2);
                Console.WriteLine("Third: " + x3);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_8()
        {
            int choice;

            double P = 0, Y = 0, S = 0, D = 0;


            do
            {
                Console.Write("Price of the Purchased Price: ");
                P = Convert.ToInt32(Console.ReadLine());

                Console.Write("Years of Service: ");
                Y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Salvage Value: ");
                S = Convert.ToInt32(Console.ReadLine());

                D = (P - S) / Y;

                Console.WriteLine("The Yearly Depreciation of this Item: " + D);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_9()
        {
            int choice;

            double num1 = 2, R = 0, S = 0, I = 0, EOQ = 0;

            do
            {
                Console.Write("Total Yearly Production Requirement: ");
                R = Convert.ToDouble(Console.ReadLine());

                Console.Write("Set Up Cost Production: ");
                S = Convert.ToDouble(Console.ReadLine());

                Console.Write("Inventory Carrying cost per Unit: ");
                I = Convert.ToDouble(Console.ReadLine());

                EOQ = Math.Sqrt(num1 * R * S) / I;

                Console.WriteLine("The Economic Order Quantity: " + EOQ);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_10()
        {
            int choice;

            double A = 0, r = 0;
            const double P = 3.1415926536;

            do
            {
                Console.Write("Enter Area: ");

                A = Convert.ToDouble(Console.ReadLine());

                r = Math.Sqrt(A / P);

                Console.WriteLine("The Radius of the Cirle: " + r);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void module_2()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_2.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_2_1(); break;
                    case 2: mp_2_2(); break;
                    case 3: mp_2_3(); break;
                    case 4: mp_2_4(); break;
                    case 5: mp_2_5(); break;
                    case 6: mp_2_6(); break;
                    case 7: mp_2_7(); break;
                    case 8: mp_2_8(); break;
                    case 9: mp_2_9(); break;
                    case 10: mp_2_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_1()
        {
            int choice;

            char letter;

            do
            {
                Console.Write("Enter a Letter: ");

                letter = Convert.ToChar(Console.ReadLine());

                switch (letter)
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                        Console.WriteLine("Vowel"); break;

                    default:
                        Console.WriteLine("Consonant"); break;
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_2()
        {
            int choice;

            int month = 0, day = 0;

            do
            {
                Console.Write("Enter Date: ");

                month = Convert.ToInt32(Console.ReadLine());

                day = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1: Console.WriteLine("January " + day); break;
                    case 2: Console.WriteLine("February " + day); break;
                    case 3: Console.WriteLine("March " + day); break;
                    case 4: Console.WriteLine("April " + day); break;
                    case 5: Console.WriteLine("May " + day); break;
                    case 6: Console.WriteLine("June " + day); break;
                    case 7: Console.WriteLine("July " + day); break;
                    case 8: Console.WriteLine("August " + day); break;
                    case 9: Console.WriteLine("September " + day); break;
                    case 10: Console.WriteLine("October " + day); break;
                    case 11: Console.WriteLine("November " + day); break;
                    case 12: Console.WriteLine("December " + day); break;

                    default: Console.WriteLine("Unknown " + day); break;
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_3()
        {
            int choice;

            double temp;

            do
            {
                Console.Write("Enter Number for Temperature: ");

                temp = Convert.ToInt32(Console.ReadLine());

                if (temp < 0)
                {
                    Console.WriteLine("Ice");
                }

                else if (temp <= 100)
                {
                    Console.WriteLine("Water");
                }

                else
                {
                    Console.WriteLine("Steam");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_4()
        {
            int choice;

            int length;

            do
            {
                Console.Write("Enter Plane Length: ");

                length = Convert.ToInt32(Console.ReadLine());

                if (length >= 52)
                {
                    Console.WriteLine("Civilian");
                }

                else if (length >= 20)
                {
                    Console.WriteLine("Military");
                }

                else
                {
                    Console.WriteLine("It is a bird!");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_5()
        {
            int choice;

            char ship;


            do
            {
                Console.Write("Enter Letter for the Ship: ");

                ship = Convert.ToChar(Console.ReadLine());

                switch (ship)
                {
                    case 'B':
                    case 'b': Console.WriteLine("Battleship"); break;
                    case 'C':
                    case 'c': Console.WriteLine("Cruiser"); break;
                    case 'D':
                    case 'd': Console.WriteLine("Destroyer"); break;
                    case 'F':
                    case 'f': Console.WriteLine("Frigate"); break;

                    default: Console.WriteLine("What??"); break;

                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_6()
        {
            int choice;

            double richter = 0;

            do
            {
                Console.Write("Richter Scale by Number: ");
                richter = Convert.ToDouble(Console.ReadLine());

                if (richter <= 5.0)
                {
                    Console.WriteLine("Little or No Damage");
                }

                else if (richter <= 5.5)
                {
                    Console.WriteLine("Some Damage");
                }

                else if (richter <= 6.5)
                {
                    Console.WriteLine("Serious Damage");
                }

                else if (richter <= 7.5)
                {
                    Console.WriteLine("Disaster");
                }

                else
                {
                    Console.WriteLine("Catastrophe");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_7()
        {
            int choice;

            int number = 0, thousand, hundred, tens, ones;
            string thousandstr, hundredstr, tensstr, onesstr;

            do
            {
                Console.Write("Enter a Number: ");
                number = Convert.ToInt32(Console.ReadLine());

                thousandstr = "";
                hundredstr = "";
                tensstr = "";
                onesstr = "";

                thousand = number % 1000;
                thousand = number - thousand;

                hundred = number - thousand;
                tens = hundred % 100;
                hundred = hundred - tens;

                ones = tens % 10;
                tens = tens - ones;

                switch (thousand)
                {
                    case 1000: thousandstr = "One " + "Thousand "; break;
                    case 2000: thousandstr = "Two " + "Thousand "; break;
                    case 3000: thousandstr = "Three " + "Thousand "; break;
                }
                if (thousand >= 0) { Console.Write(thousandstr); }

                switch (hundred)
                {
                    case 100: hundredstr = "One " + "Hundred "; break;
                    case 200: hundredstr = "Two " + "Hundred "; break;
                    case 300: hundredstr = "Three " + "Hundred "; break;
                    case 400: hundredstr = "Four " + "Hundred "; break;
                    case 500: hundredstr = "Five " + "Hundred "; break;
                    case 600: hundredstr = "Six " + "Hundred "; break;
                    case 700: hundredstr = "Seven " + "Hundred "; break;
                    case 800: hundredstr = "Eight " + "Hundred "; break;
                    case 900: hundredstr = "Nine " + "Hundred "; break;
                }
                if (hundred >= 0) { Console.Write(hundredstr); }

                switch (tens)
                {
                    case 20: tensstr = "Twenty "; break;
                    case 30: tensstr = "Thirty "; break;
                    case 40: tensstr = "Forty "; break;
                    case 50: tensstr = "Fifty "; break;
                    case 60: tensstr = "Sixty "; break;
                    case 70: tensstr = "Seventy "; break;
                    case 80: tensstr = "Eighty "; break;
                    case 90: tensstr = "Ninety "; break;
                }
                if (tens >= 0) { Console.Write(tensstr); }

                switch (ones)
                {
                    case 01: onesstr = "One "; break;
                    case 02: onesstr = "Two "; break;
                    case 03: onesstr = "Three "; break;
                    case 04: onesstr = "Four "; break;
                    case 05: onesstr = "Five "; break;
                    case 06: onesstr = "Six "; break;
                    case 07: onesstr = "Seven "; break;
                    case 08: onesstr = "Eight "; break;
                    case 09: onesstr = "Nine "; break;
                    case 10: onesstr = "Ten "; break;
                    case 11: onesstr = "Eleven "; break;
                    case 12: onesstr = "Twelve "; break;
                    case 13: onesstr = "Thirteen "; break;
                    case 14: onesstr = "Fourteen "; break;
                    case 15: onesstr = "Fifteen "; break;
                    case 16: onesstr = "Sixteen "; break;
                    case 17: onesstr = "Seventeen "; break;
                    case 18: onesstr = "Eighteen "; break;
                    case 19: onesstr = "Nineteen "; break;
                }
                if (ones >= 0) { Console.Write(onesstr); }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_8()
        {
            int choice;

            int number = 0, thousand, hundred, tens, ones;
            string thousandstr, hundredstr, tensstr, onesstr;


            do
            {
                Console.Write("Enter a Number: ");
                number = Convert.ToInt32(Console.ReadLine());

                thousandstr = "";
                hundredstr = "";
                tensstr = "";
                onesstr = "";

                thousand = number % 1000;
                thousand = number - thousand;

                hundred = number - thousand;
                tens = hundred % 100;
                hundred = hundred - tens;

                ones = tens % 10;
                tens = tens - ones;

                switch (thousand)
                {
                    case 1000: thousandstr = "M"; break;
                    case 2000: thousandstr = "MM"; break;
                    case 3000: thousandstr = "MMM"; break;
                }
                if (thousand >= 0) { Console.Write(thousandstr); }

                switch (hundred)
                {
                    case 100: hundredstr = "C"; break;
                    case 200: hundredstr = "CC"; break;
                    case 300: hundredstr = "CCC"; break;
                    case 400: hundredstr = "CD"; break;
                    case 500: hundredstr = "D"; break;
                    case 600: hundredstr = "DC"; break;
                    case 700: hundredstr = "DCC"; break;
                    case 800: hundredstr = "DCCC"; break;
                    case 900: hundredstr = "CM"; break;
                }
                if (hundred >= 0) { Console.Write(hundredstr); }

                switch (tens)
                {
                    case 10: tensstr = "X"; break;
                    case 20: tensstr = "XX"; break;
                    case 30: tensstr = "XXX"; break;
                    case 40: tensstr = "XL"; break;
                    case 50: tensstr = "L"; break;
                    case 60: tensstr = "LX"; break;
                    case 70: tensstr = "LXX"; break;
                    case 80: tensstr = "LXXX"; break;
                    case 90: tensstr = "XC"; break;
                }
                if (tens >= 0) { Console.Write(tensstr); }

                switch (ones)
                {
                    case 01: onesstr = "I"; break;
                    case 02: onesstr = "II"; break;
                    case 03: onesstr = "III"; break;
                    case 04: onesstr = "IV"; break;
                    case 05: onesstr = "V"; break;
                    case 06: onesstr = "VI"; break;
                    case 07: onesstr = "VII"; break;
                    case 08: onesstr = "VIII"; break;
                    case 09: onesstr = "IX"; break;
                    case 10: onesstr = "X"; break;
                    case 11: onesstr = "XI"; break;
                    case 12: onesstr = "XII"; break;
                    case 13: onesstr = "XIII"; break;
                    case 14: onesstr = "XIV"; break;
                    case 15: onesstr = "XV"; break;
                    case 16: onesstr = "XVI"; break;
                    case 17: onesstr = "XVII"; break;
                    case 18: onesstr = "XVIII"; break;
                    case 19: onesstr = "XIX"; break;
                }
                if (ones >= 0) { Console.Write(onesstr); }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_9()
        {
            int choice;

            int fee, payment;
            double total;

            do
            {
                Console.Write("Enter Tuition Fee: ");
                fee = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Mode for Payment: ");
                payment = Convert.ToInt32(Console.ReadLine());


                if (payment == 1)
                {
                    total = fee * 0.10;

                    Console.WriteLine("Your Total Tuition Fee is: " + total);
                }

                else if (payment == 2)
                {
                    total = fee * 0.05;
                    total = fee - total;

                    Console.WriteLine("Your Total Tuition Fee is: " + total);
                }

                else if (payment == 3)
                {
                    total = fee * 0.10 * 12;

                    Console.WriteLine("Your Total Tuition Fee is: " + total);
                }

                else
                {
                    Console.WriteLine("Not Available");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_2_10()
        {
            int choice;

            int range;
            double grade;

            do
            {
                Console.Write("Enter Range by Percent: ");
                range = Convert.ToInt32(Console.ReadLine());

                switch (range)
                {
                    case 100:
                    case 99:
                    case 98: grade = 1.00; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 97:
                    case 96:
                    case 95: grade = 1.25; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 94:
                    case 93:
                    case 92: grade = 1.50; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 91:
                    case 90:
                    case 89: grade = 1.75; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 88:
                    case 87:
                    case 86:
                    case 85: grade = 2.00; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 84:
                    case 83:
                    case 82: grade = 2.25; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 81:
                    case 80: grade = 2.50; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 79:
                    case 78:
                    case 77: grade = 2.75; Console.WriteLine("Grade Equivalent: " + grade); break;
                    case 76:
                    case 75: grade = 3.00; Console.WriteLine("Grade Equivalent: " + grade); break;

                    default: Console.WriteLine("Out of Range..."); break;
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }
        static void module_3()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_3.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_3_1(); break;
                    case 2: mp_3_2(); break;
                    case 3: mp_3_3(); break;
                    case 4: mp_3_4(); break;
                    case 5: mp_3_5(); break;
                    case 6: mp_3_6(); break;
                    case 7: mp_3_7(); break;
                    case 8: mp_3_8(); break;
                    case 9: mp_3_9(); break;
                    case 10: mp_3_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_1()
        {
            int choice;

            int seq = 0, squ = 0, num;
            do
            {
                Console.Write("Enter Number for Sequence: ");
                num = Convert.ToInt32(Console.ReadLine());
                seq = num;

                do
                {
                    squ = seq;
                    squ = seq * squ;
                    Console.WriteLine(seq + "                " + squ);
                    seq++;
                }
                while (seq <= 10);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_2()
        {
            int choice;

            int num1, num2;

            do
            {
                Console.Write("Enter a start Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = 1;

                do
                {

                    Console.Write(num2 + " " + num1 + " ");

                    num1--;
                    num2++;

                    if (num2 == num1)
                    {
                        Console.Write(num2 + " " + num1 + " ");
                        num1--;
                        num2++;
                    }

                    else if (num2 >= num1)
                    {
                        Console.Write(num2 + " " + num1 + " ");
                        num1--;
                        num2++;

                        Console.Write(num2 + " " + num1 + " ");
                        num1--;
                        num2++;
                    }

                    else if (num2 <= num1)
                    {
                        Console.Write(num2 + " " + num1 + " ");
                        num1--;
                        num2++;
                    }
                }
                while (num2 <= num1);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_3()
        {
            int choice;

            int num1, num2;


            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = 1;

                do
                {
                    Console.Write(num1 + " " + num2 + " ");
                    num1--;
                    num2++;

                    if (num1 == num2)
                    {
                        Console.Write(num1 + " " + num2 + " ");
                        num1--;
                        num2++;
                    }

                    else if (num1 <= num2)
                    {
                        Console.Write(num1 + " " + num2 + " ");
                        num1--;
                        num2++;

                        Console.Write(num1 + " " + num2 + " ");
                        num1--;
                        num2++;
                    }

                    else if (num1 >= num2)
                    {
                        Console.Write(num1 + " " + num2 + " ");
                        num1--;
                        num2++;
                    }
                }
                while (num1 >= num2);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_4()
        {
            int choice;

            int num1, num2, num3;

            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = 1;
                num3 = 1;

                Console.Write("The Computation is: ");

                do
                {
                    Console.Write(num2);

                    num3 = num2 * num3;

                    if (num2 == num1)
                    {
                        Console.Write(" =  " + num3);
                    }

                    else
                    {
                        Console.Write(" * ");
                    }

                    num2++;
                }
                while (num2 <= num1);

                Console.WriteLine("     The Factorial Value is:  " + num3);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_5()
        {
            int choice;

            int num1, num2 = 1, num3 = 1, num4, num5;

            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("The Fibonacci Series: ");

                Console.Write(num2 + " " + num3 + " ");

                num4 = 3;

                do
                {
                    num5 = num2 + num3;

                    Console.Write(num5 + " ");

                    num2 = num3;
                    num3 = num5;

                    num4++;
                }
                while (num4 <= num1);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_6()
        {
            int choice;

            int baseno, expo, expo1, power;

            do
            {
                Console.Write("Enter a Base Number: ");
                baseno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a Number as Exponent: ");
                expo = Convert.ToInt32(Console.ReadLine());

                Console.Write("The Computation is: ");

                power = baseno;

                expo1 = 1;

                do
                {
                    Console.Write(baseno);

                    if (expo1 == expo)
                    {
                        Console.Write(" = " + power + " ");
                    }

                    else
                    {
                        power = power * baseno;
                        Console.Write(" * ");
                    }

                    expo1++;
                }
                while (expo1 <= expo);

                Console.WriteLine("The Power Value of " + baseno + " is " + power);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_7()
        {
            int choice;

            int num1, num2 = 1, num3 = 0, result;

            do
            {
                Console.Write("Enter a Base Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.Write(num2 * num2);

                    num3 += num2 * num2;

                    if (num2 == num1)
                    {
                        result = num3;
                        Console.Write(" = " + result + " ");
                    }

                    else
                    {
                        Console.Write(" + ");
                    }

                    num2++;

                } while (num2 <= num1);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_8()
        {
            int choice;

            int num1, num2 = 1, num3 = 0, result;

            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.Write(num2);

                    num3 += num2;

                    if (num2 == num1)
                    {
                        result = num3;

                        Console.Write(" = " + result + " ");
                    }

                    else
                    {
                        Console.Write(" + ");
                    }

                    num2++;
                } while (num2 <= num1);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_9()
        {
            int choice;

            int num1, num2, rev;

            do
            {
                Console.Write("Enter a Number/s: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                rev = 0;

                do
                {
                    num2 = num1 % 10;
                    rev = (rev * 10) + num2;
                    num1 = num1 / 10;
                }
                while (num1 > 0);

                Console.WriteLine("The Reversed Version is: " + rev);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_3_10()
        {
            int choice;

            int num1, num2, num3 = 0, result;

            do
            {
                Console.Write("Enter Area: ");

                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = 1;

                while (num2 <= num1)
                {
                    num3 += (int)Math.Pow(num2, num2);

                    Console.Write(num2 + " ^ ( " + num2 + " )");

                    if (num2 == num1)
                    {
                        result = num3;

                        Console.Write(" = " + result);
                    }

                    else
                    {
                        Console.Write(" + ");
                    }

                    num2++;
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }
        static void module_4()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_4.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_4_1(); break;
                    case 2: mp_4_2(); break;
                    case 3: mp_4_3(); break;
                    case 4: mp_4_4(); break;
                    case 5: mp_4_5(); break;
                    case 6: mp_4_6(); break;
                    case 7: mp_4_7(); break;
                    case 8: mp_4_8(); break;
                    case 9: mp_4_9(); break;
                    case 10: mp_4_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_1()
        {
            int choice;
            double r;

            do
            {
                Console.Write("Enter a Number for Radius: ");
                r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The Area of a Sphere is: " + val_Sphere(r) + "\n");

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_2()
        {
            int choice;

            double inc;
            do
            {
                Console.Write("Inches: ");
                inc = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Centimeter: " + centi_val(inc) + "\n");

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_3()
        {
            int choice;

            double fahren;
            do
            {
                Console.Write("Fahrenheit: ");
                fahren = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Temperature in Celsius: " + celsiuS(fahren) + "\n");

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_4()
        {
            int choice;

            double cels;
            do
            {
                Console.Write("Celsius: ");
                cels = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Temperature in Fahrenheit: " + Fahren(cels) + "\n");

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_5()
        {
            int choice;

            int num1;
            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                FiBo(num1);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_6()
        {
            int choice;

            int baseno;
            do
            {
                Console.Write("Number as Base Number: ");
                baseno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\n" + "Power Value is: " + val_pow(baseno));
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_7()
        {
            int choice;

            int num1;
            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + "Total Number from the Sum of the Squares is: " + total_num(num1));
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_8()
        {
            int choice;

            int num1;
            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + "Result from Sum of Sequence: " + sum_seq(num1));
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_9()
        {
            int choice;

            double dollar;
            do
            {
                Console.Write("Enter a Value for US Dollar: ");
                dollar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n\n" + "Equivent to Peso is: " + phP(dollar));
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_4_10()
        {
            int choice;

            int num1;
            do
            {
                Console.Write("Enter a Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\n" + "Result from the Sum of the Powers is: " + power_Sum(num1));
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }
        static void module_5()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_5.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_5_1(); break;
                    case 2: mp_5_2(); break;
                    case 3: mp_5_3(); break;
                    case 4: mp_5_4(); break;
                    case 5: mp_5_5(); break;
                    case 6: mp_5_6(); break;
                    case 7: mp_5_7(); break;
                    case 8: mp_5_8(); break;
                    case 9: mp_5_9(); break;
                    case 10: mp_5_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_1()
        {
            int choice;


            do
            {
                int[] num = new int[5];
                int pros = 0;
                double grad;
                int d;

                for (d = 0; d <= 4; d++)
                {
                    Console.Write("Enter a value for [" + (d + 1) + "]: ");
                    num[d] = Convert.ToInt32(Console.ReadLine());
                }

                for (d = 0; d <= 4; d++)
                {
                    pros = pros + num[d];
                }

                grad = pros / 5;
                Console.WriteLine("Average: " + grad);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_2()
        {
            int choice;
            do
            {
                int[] num = new int[5];
                int low = 0;
                int r;

                for (r = 0; r <= 4; r++)
                {
                    Console.Write("Enter Numbers for [" + (r + 1) + "]: ");
                    num[r] = Convert.ToInt32(Console.ReadLine());
                }

                low = num[0];

                for (r = 0; r <= 4; r++)
                {
                    if (low > num[r])
                    {
                        low = num[r];
                    }
                }

                Console.WriteLine("Lowest Value: " + low);

                Console.WriteLine("Difference of value from the Lowest: " + low);
                for (r = 0; r <= 4; r++)
                {
                    Console.WriteLine("Number [" + (r + 1) + "]: " + num[r] + " - " + low + " = " + (num[r] - low));
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_3()
        {
            int choice;
            do
            {
                int[] num = new int[5];
                int num_search = 0;
                int f;

                for (f = 0; f <= 4; f++)
                {
                    Console.Write("Enter a value for [" + (f + 1) + "]: ");
                    num[f] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Place a Number to Search: ");
                num_search = Convert.ToInt32(Console.ReadLine());

                for (f = 0; f <= 4; f++)
                {
                    Console.WriteLine("Number [" + (f + 1) + "]: ");
                    if (num_search == num[f])
                    {
                        Console.WriteLine("Searched Number is Found!");
                    }
                    else
                    {
                        Console.WriteLine("Search Number is Missing!");
                    }

                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_4()
        {
            int choice;
            do
            {
                double[,] num = new double[2, 12];
                int pointodd = 0;
                int element = 11;
                int f;

                for (f = 0; f <= element; f++)
                {
                    Console.Write("Enter Value / Number for [" + (f + 1) + "]: ");
                    num[0, f] = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Input Number: ");
                for (f = 0; f <= element; f++)
                {
                    Console.Write(num[0, f] + " , ");
                }

                Console.WriteLine("\n\n Odd Numbers: ");
                for (f = 0; f <= element; f++)
                {
                    if ((num[0, f] % 2) == 0)
                    {
                        //Nothing
                    }

                    else
                    {
                        num[1, pointodd] = num[0, f];
                        pointodd++;
                    }
                }

                for (f = 0; f < pointodd; f++)
                {
                    Console.Write(num[1, f] + " , ");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_5()
        {
            int choice;
            do
            {
                double[,] num = new double[2, 12];
                int num_search = 0, occu = 0;
                int element = 11;
                int f;

                for (f = 0; f <= element; f++)
                {
                    Console.Write("Enter Value / Number for [" + (f + 1) + "]: ");
                    num[0, f] = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Input Number: ");
                for (f = 0; f <= element; f++)
                {
                    Console.Write(num[0, f] + " , ");
                }

                Console.Write("Enter a Number to search: ");
                num_search = Convert.ToInt32(Console.ReadLine());
                for (f = 0; f <= element; f++)
                {
                    if (num_search == num[0, f])
                    {
                        occu = occu + 1;
                    }

                    else
                    {

                    }
                }

                Console.WriteLine("Occurence: " + occu);
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_6()
        {
            int choice;
            do
            {
                int[,] num = new int[2, 12];
                int pross = 0, grad = 0;
                int element = 11;
                int f;

                for (f = 0; f <= element; f++)
                {
                    Console.Write("Enter Value / Number for [" + (f + 1) + "]: ");
                    num[0, f] = Convert.ToInt32(Console.ReadLine());
                }

                for (f = 0; f <= element; f++)
                {
                    pross = pross + num[0, f];
                }

                Console.WriteLine("Total: " + pross);
                grad = pross / 12;
                Console.WriteLine("Average: " + grad);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_7()
        {
            int choice;
            do
            {
                int[] num = new int[12];
                int high = 0, low = 0;
                int element = 11;
                int f;

                for (f = 0; f <= element; f++)
                {
                    Console.Write("Enter Value / Number for [" + (f + 1) + "]: ");
                    num[f] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Input Number: ");
                for (f = 0; f <= element; f++)
                {
                    Console.Write(num[f] + " , ");
                }

                high = num[0];
                low = num[0];
                for (f = 0; f <= element; f++)
                {
                    if (num[f] > high)
                    {
                        high = num[f];
                    }

                    if (num[f] < low)
                    {
                        low = num[f];
                    }
                }

                Console.WriteLine("The Highest Number is: " + high);
                Console.WriteLine("The Lowest Number is: " + low);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_8()
        {
            int choice;
            do
            {
                double[,] num = new double[2, 12];
                int pointodd = 0, pointeven = 0;
                int element = 11;
                int f;

                for (f = 0; f <= element; f++)
                {
                    Console.Write("Enter Value / Number for [" + (f + 1) + "]: ");
                    num[0, f] = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Input Number: ");
                for (f = 0; f <= element; f++)
                {
                    Console.Write(num[0, f] + " , ");
                }
                for (f = 0; f <= element; f++)
                {
                    if ((num[0, f] % 2) == 0)
                    {
                        num[1, pointeven] = num[0, f];
                        pointeven++;
                    }

                    else
                    {
                        num[1, pointodd] = num[0, f];
                        pointodd++;
                    }
                }

                Console.Write("Odd Number: ");
                for (f = 0; f < pointodd; f++)
                {
                    Console.Write(num[1, f] + " , ");
                }
                Console.WriteLine("");
                Console.Write("Even Number: ");
                for (f = 0; f < pointeven; f++)
                {
                    Console.Write(num[1, f] + " , ");
                }

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_9()
        {
            int choice;
            do
            {
                int[] numbers = new int[3];
                int sum = 0, sum1 = 0, sum2 = 0, avg = 0;

                double element2 = 2;
                int i;
                Console.WriteLine("input three number");
                for (i = 0; i <= 2; i++)
                {

                    Console.Write(" {" + (i + 1) + "} = ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }
                for (i = 0; i <= 2; i++)
                {

                    Console.Write("{" + numbers[i] + "},");
                    sum = sum + numbers[i];


                }

                Console.WriteLine("");
                for (i = 0; i < 3; i++)
                {
                    Console.Write(" {" + (i + 1) + "} = ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }

                for (i = 0; i < 3; i++)
                {

                    Console.Write("{" + numbers[i] + "},");
                    sum1 = sum1 + numbers[i];

                }

                Console.WriteLine("");
                for (i = 0; i < 3; i++)
                {
                    Console.Write(" {" + (i + 1) + "} = ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }

                for (i = 0; i < 3; i++)
                {

                    Console.Write("{" + numbers[i] + "},");
                    sum2 = sum2 + numbers[i];

                }
                Console.WriteLine("\n----------------------------------------------------------");

                Console.Write(sum + ","); Console.Write(sum1 + ","); Console.Write(sum2 + ",");
                avg = (int)(sum / element2);
                Console.ReadLine();

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_5_10()
        {
            int choice;
            do
            {
                int[] number = new int[5];
                int loc = 0;
                int nsearch;

                Console.Write("Enter list of numbers: ");
                for (int i = 0; i < number.Length; i++)
                {
                    Console.Write("number [" + (i) + "] = ");
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Enter a number that searching for: ");
                nsearch = Convert.ToInt32(Console.ReadLine());
                foreach (int c in number)
                {
                    if (c == nsearch)
                    {
                        Console.WriteLine(nsearch + " found in location" + loc);
                        break;
                    }

                    loc++;
                }
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void module_6()
        {
            int choice;
            do
            {
                Console.CursorVisible = true;
                ReadText("module_6.txt");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1: mp_6_1(); break;
                    case 2: mp_6_2(); break;
                    case 3: mp_6_3(); break;
                    case 4: mp_6_4(); break;
                    case 5: mp_6_5(); break;
                    case 6: mp_6_6(); break;
                    case 7: mp_6_7(); break;
                    case 8: mp_6_8(); break;
                    case 9: mp_6_9(); break;
                    case 10: mp_6_10(); break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_1()
        {
            int choice;
            do
            {
                string strcode = "";
                string strprice;

                Console.Write("Enter Price: ");
                strprice = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < strprice.Length; i++)
                {
                    if (strprice[i] == 0)
                        strcode += 'X';

                    else if (strprice[i] == '1')
                        strcode += 'C';

                    else if (strprice[i] == '2')
                        strcode += 'O';

                    else if (strprice[i] == '3')
                        strcode += 'M';

                    else if (strprice[i] == '4')
                        strcode += 'P';

                    else if (strprice[i] == '5')
                        strcode += 'U';

                    else if (strprice[i] == '6')
                        strcode += 'T';

                    else if (strprice[i] == '7')
                        strcode += 'E';

                    else if (strprice[i] == '8')
                        strcode += 'R';

                    else if (strprice[i] == '9')
                        strcode += 'S';

                    else if (strprice[i] == '.')
                        strcode += '.';

                }
                Console.WriteLine("Coded Value: " + strcode);
                Console.ReadKey();
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_2()
        {
            int choice;
            do
            {
                string strcode;
                string strprice = "";

                Console.Write("Enter Code: ");
                strcode = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < strcode.Length; i++)
                {
                    if (strcode[i] == 'X')
                        strprice += '0';

                    else if (strcode[i] == 'C')
                        strprice += '1';

                    else if (strcode[i] == 'O')
                        strprice += '2';

                    else if (strcode[i] == 'M')
                        strprice += '3';

                    else if (strcode[i] == 'P')
                        strprice += '4';

                    else if (strcode[i] == 'U')
                        strprice += '5';

                    else if (strcode[i] == 'T')
                        strprice += '6';

                    else if (strcode[i] == 'E')
                        strprice += '7';

                    else if (strcode[i] == 'R')
                        strprice += '8';

                    else if (strcode[i] == 'S')
                        strprice += '9';

                    else if (strcode[i] == '.')
                        strprice += '.';

                }
                Console.WriteLine("Price: " + strprice);
                Console.ReadKey();
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_3()
        {
            int choice;
            do
            {
                string strmessage;

                Console.Write("Enter a Message: ");
                strmessage = Convert.ToString(Console.ReadLine());

                Reverse(strmessage);

                Console.Write("\n" + Reverse(strmessage));

                if (Reverse(strmessage) == strmessage)
                {
                    Console.WriteLine(" - This is Palindrome");
                }
                else
                {
                    Console.WriteLine(" - This is not Palindrome");
                }
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_4()
        {
            int choice;
            do
            {
                string strmessage;

                Console.Write("Enter a Message: ");
                strmessage = Convert.ToString(Console.ReadLine());

                strmessage = encrypt(strmessage);
                Console.WriteLine("\n" + strmessage);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_5()
        {
            int choice;
            do
            {
                string strmessage;

                Console.Write("Enter a Message: ");
                strmessage = Convert.ToString(Console.ReadLine());

                strmessage = incrypt(strmessage);
                Console.WriteLine("\n" + strmessage);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_6()
        {
            int choice;
            do
            {
                Console.Write("Enter country: ");
                string capital = CapicalC(Console.ReadLine().Trim());
                if (capital != "")
                    Console.WriteLine("Capital city: " + capital);
                else
                    Console.WriteLine("Not Found");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_7()
        {
            int choice;
            do
            {
                Console.Write("Enter Capital: ");
                string capital = Country(Console.ReadLine().Trim());
                if (capital != "")
                    Console.WriteLine("Country: " + capital);
                else
                    Console.WriteLine("Not Found");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_8()
        {
            int choice;
            do
            {
                Console.Write("Enter country: ");
                string capital = Currency(Console.ReadLine().Trim());
                if (capital != "")
                    Console.WriteLine("Currency: " + capital);
                else
                    Console.WriteLine("Not Found");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_9()
        {
            int choice;
            do
            {
                string strWord;

                Console.Write("Enter a word: ");
                strWord = Convert.ToString(Console.ReadLine());
                strWord = strWord + "   ";

                strWord = Plurals(strWord, (strWord.Length - 1));

                Console.WriteLine("\n\n" + strWord);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }

        static void mp_6_10()
        {
            int choice;
            do
            {
                Console.Write("Input string value: ");
                string words = Console.ReadLine();
                string[] s = words.Split(' ');
                Array.Reverse(s);
                string result = string.Join(" ", s);
                Console.WriteLine("Reversed: {0}", result);

                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                }
            }
            while (choice != 0);
        }


        static void ReadText(string pathx)
        {
            try
            {
                Console.Clear();
                using (StreamReader sr = new StreamReader(pa + pathx))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("The File could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        static double val_Sphere(double r)
        {
            double a = 0;
            const double Pi = 3.1415926536;

            r = r * r;
            a = Pi * r;

            return a;
        }

        private static double centi_val(double inc)
        {
            double cent;
            const double equiv = 2.54;

            cent = inc * equiv;

            return cent;
        }

        private static double celsiuS(double fahren)
        {
            double cels, num1 = 5.0, num2 = 9.0;
            const double con = 32.0;

            cels = (num1 / num2) * fahren - con;

            return cels;
        }

        private static double Fahren(double cels)
        {
            double fahren = 0, num1 = 5.0, num2 = 9.0;
            const double con = 32.0;

            fahren = (num2 / num1) * cels + con;

            return fahren;
        }

        private static int FiBo(int num1)
        {
            int num2 = 1, num3 = 1, num4, num5 = 0;

            Console.Write("In Fibonacci: " + num2 + " " + num3 + " ");

            num4 = 2;

            while (num4 <= num1)
            {
                num5 = num2 + num3;

                Console.Write(num5 + " ");

                num2 = num3;
                num3 = num5;

                num4++;
            }

            return num1;
        }

        private static int val_pow(int baseno)
        {
            int powval = baseno, expo1 = 1, expo = 0;

            Console.Write("Number as Exponent: ");
            expo = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(baseno);

                if (expo == expo1)
                {
                    Console.Write(" = " + powval + " " + "\n\n");
                }
                else
                {
                    powval = powval * baseno;
                    Console.Write(" * ");
                }

                expo1++;
            } while (expo1 <= expo);

            return powval;
        }

        private static int total_num(int num1)
        {
            int to_num = 0, ill = 1, result = 0;

            Console.Write("Result: ");

            while (ill <= num1)
            {
                Console.Write(ill * ill);

                to_num += ill * ill;

                if (ill == num1)
                {
                    result = to_num;
                    Console.Write(" = " + result + " ");
                }

                else
                {
                    Console.Write(" + ");
                }

                ill++;
            }
            return result;
        }

        private static int sum_seq(int num1)
        {
            int num2, rec = 0, result = 0;

            for (num2 = 1; num2 <= num1; num2++)
            {
                Console.Write(num2);

                rec += num2;

                if (num2 == num1)
                {
                    result = rec;
                    Console.Write(" = " + result + " ");
                }
                else
                {
                    Console.Write(" + ");
                }
            }
            return rec;
        }

        private static double phP(double dollar)
        {
            double p = 0;
            const double equiv = 53.80;

            p = dollar * equiv;
            return p;
        }

        private static int power_Sum(int num1)
        {
            int num2, num3 = 0, result = 0;

            for (num2 = 1; num2 <= num1; num2++)
            {

                num3 += (int)Math.Pow(num2, num2);

                Console.Write(num2 + " ^ (" + num2 + ")");

                if (num2 == num1)
                {
                    result = num3;

                    Console.Write(" = " + result);
                }

                else
                {
                    Console.Write(" + ");
                }

            }
            return result;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string encrypt(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if ((charArray[i] == 'A') || (charArray[i] == 'a'))
                {
                    charArray[i] = '*';
                }

                else if ((charArray[i] == 'E') || (charArray[i] == 'e'))
                {
                    charArray[i] = '$';
                }

                else if ((charArray[i] == 'I') || (charArray[i] == 'i'))
                {
                    charArray[i] = '/';
                }

                else if ((charArray[i] == 'O') || (charArray[i] == 'o'))
                {
                    charArray[i] = '+';
                }

                else if ((charArray[i] == 'U') || (charArray[i] == 'u'))
                {
                    charArray[i] = '-';
                }
            }
            return new string(charArray);
        }

        public static string incrypt(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if ((charArray[i] == '*'))
                {
                    charArray[i] = 'a';
                }

                else if ((charArray[i] == '$'))
                {
                    charArray[i] = 'e';
                }

                else if ((charArray[i] == '/'))
                {
                    charArray[i] = 'i';
                }

                else if ((charArray[i] == '+'))
                {
                    charArray[i] = 'o';
                }

                else if ((charArray[i] == '-'))
                {
                    charArray[i] = 'u';
                }
            }
            return new string(charArray);
        }

        private static string CapicalC(string country)
        {
            if (country.Equals("Canada", StringComparison.InvariantCultureIgnoreCase))
                return "Ottawa";

            if (country.Equals("United States", StringComparison.InvariantCultureIgnoreCase))
                return "Washington D.C.";

            if (country.Equals("U.S.S.R.", StringComparison.InvariantCultureIgnoreCase))
                return "Moscow";

            if (country.Equals("Italy", StringComparison.InvariantCultureIgnoreCase))
                return "Rome";

            if (country.Equals("Philippines", StringComparison.InvariantCultureIgnoreCase))
                return "Manila";

            return "";
        }

        private static string Country(string capital)
        {
            if (capital.Equals("Ottawa", StringComparison.InvariantCultureIgnoreCase))
                return "Canada";

            if (capital.Equals("Washington D.C.", StringComparison.InvariantCultureIgnoreCase))
                return "United States";

            if (capital.Equals("Moscow", StringComparison.InvariantCultureIgnoreCase))
                return "U.S.S.R.";

            if (capital.Equals("Rome", StringComparison.InvariantCultureIgnoreCase))
                return "Italy";

            if (capital.Equals("Manila", StringComparison.InvariantCultureIgnoreCase))
                return "Philippines";

            return "";
        }

        private static string Currency(string country)
        {
            if (country.Equals("British", StringComparison.InvariantCultureIgnoreCase))
                return "Pound" + " = 0.6 U.S Dollar";

            if (country.Equals("Canadian", StringComparison.InvariantCultureIgnoreCase))
                return "Dollar" + " = 1.3 U.S Dollar";

            if (country.Equals("Japanese", StringComparison.InvariantCultureIgnoreCase))
                return "Yen" + " = 140 U.S Dollar";

            if (country.Equals("German", StringComparison.InvariantCultureIgnoreCase))
                return "Mark" + " = 1.7 U.S Dollar";

            if (country.Equals("Philippine", StringComparison.InvariantCultureIgnoreCase))
                return "Peso" + " = 53 U.S Dollar";

            return "";
        }

        public static string Plurals(string chat, int num)
        {
            char[] charArray = chat.ToCharArray();
            if (charArray[num - 3] == 'y')
            {
                charArray[num - 3] = 'i';
                charArray[num - 2] = 'e';
                charArray[num - 1] = 's';
            }

            else if (charArray[num - 3] == 's')
            {
                charArray[num - 2] = 'e';
                charArray[num - 1] = 's';
            }

            else if ((charArray[num - 3] == 'h') && (((charArray[num - 4] == 'c') || ((charArray[num - 4] == 's')))))
            {
                charArray[num - 2] = 'e';
                charArray[num - 1] = 's';
            }

            else
            {
                charArray[num - 2] = 's';
            }

            return new string(charArray);
        }


    }
}
