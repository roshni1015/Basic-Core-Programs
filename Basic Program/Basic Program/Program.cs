// See https://aka.ms/new-console-template for more information
using Basic_Program;

Console.WriteLine("Basic Core Pogram!");
while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)Swapingnumber\n2)QuotientRemainder\n3)Largestnumber\n4)VowelConsonant\n5)Evenodd\n6)Flipcoin\n7)Leapyear\n8)Powerof2\n9)HarmonicSeries");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
          swapingnumber swap = new swapingnumber();
          swap.swap();
          break;
        case 2:
            QuotientRemainder quotientRemainder = new QuotientRemainder();
            quotientRemainder.quotientRemainder();
            break;
        case 3:
            Largestnumber large = new Largestnumber();
            large.largenumber();
            break;
        case 4:
            VowelConsonant vowelConsonant = new VowelConsonant();
            vowelConsonant.vowelConsonant();
            break;
        case 5:
            Evenodd evenodd = new Evenodd();
            evenodd.evenodd();
            break;
        case 6:
            Flipcoin filpcoin = new Flipcoin();
            filpcoin.filpcoin();
            break;
        case 7:
            Leapyear leap = new Leapyear();
            leap.leap();
            break;
        case 8:
            Powerof2 power = new Powerof2();
            power.powerof2();
            break;
        case 9:
            Harmonicseries HarmonicSeries = new Harmonicseries();
            HarmonicSeries.HarmonicSeries();
            break;
        default:
          break;



            }
    }