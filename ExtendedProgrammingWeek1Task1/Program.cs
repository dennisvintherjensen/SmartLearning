﻿using System;

namespace ExtendedProgrammingWeek1Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lyrics =
            {
                "Thunder, thunder, thunder, thunder",
                "I was caught",
                "In the middle of a railroad track",
                "I looked round",
                "And I knew there was no turning back",
                "My mind raced",
                "And I thought what could I do",
                "And I knew",
                "There was no help, no help from you",
                "Sound of the drums",
                "Beating in my heart",
                "The thunder of guns",
                "Tore me apart",
                "You've been",
                "Thunderstruck",
                "Rode down the highway",
                "Broke the limit, we hit the town",
                "Went through to Texas, yeah Texas, and we had some fun",
                "We met some girls",
                "Some dancers who gave a good time",
                "Broke all the rules",
                "Played all the fools",
                "Yeah yeah they, they, they blew our minds",
                "And I was shaking at the knees",
                "Could I come again please",
                "Yeah them ladies were too kind",
                "You've been",
                "Thunderstruck",
                "I was shaking at the knees",
                "Could I come again please",
                "Thunderstruck, Thunderstruck, Thunderstruck, Thunderstruck",
                "It's alright, we're doin' fine",
                "It's alright, we're doin' fine, fine, fine",
                "Thunderstruck, yeah, yeah, yeah",
                "Thunderstruck, Thunderstruck",
                "Thunderstruck, baby, baby",
                "Thunderstruck, you've been Thunderstruck",
                "Thunderstruck, Thunderstruck",
                "You've been Thunderstruck",
            };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(lyrics[i]);
            }

            Console.ReadLine();
        }
    }
}
