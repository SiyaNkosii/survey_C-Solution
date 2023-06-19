using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication3.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CusId { get; set; }
        [Required]
        [DisplayName("Surname")]  //Data Annotations
        public string Surname { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string Fname { get; set; }
        [Required]
        [DisplayName("Contact Number")]

        public string ContactNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Person's age")]
        public DateTime Date { get; set; }
        [Required]
        [Range(5,120)]  
        public int Age { get; set; }



        [DisplayName("Pasta")]
        public  bool Pizza { get; set; }
        [DisplayName("Pasta")]
        public bool Pasta { get; set; }
        [DisplayName("Pap and Wors")]
        public bool PapWors { get; set; }
        [DisplayName("Chicken Stri Fry")]
        public bool ChickStri  { get; set; }
        [DisplayName("Beef Stri Fry")]
        public bool BeefStri { get; set; }
        [DisplayName("Other")]
        public bool Other { get; set; }



        [Required]
        [DisplayName("Eat out")]
        public string EatOut { get; set; }
        [Required]
        [DisplayName("Watch TV")]
        public string WatchTv { get; set; }
        [Required]
        [DisplayName("Watch Movie")]
        public string WatchMov { get; set; }
        [Required]
        [DisplayName("Lirsten radio")]
        public string LisRadio { get; set; }


        public double EatOutCount { get; set; } = 0;
        public double WatchTvCount { get; set; } = 0;
        public double WatchMovCount { get; set; } = 0;
        public double LisRadioCount { get; set; } = 0;



        public int PizzaCount { get; set; } = 0;
        public int PastaCount { get; set; } = 0;
        public int PapWorsCount { get; set; } = 0;
        public int ChickStriCount { get; set;} = 0;
        public int BeefStriCount { get; set; } = 0;
        public int OtherCount { get; set; } = 0;

        // fields thats gonna hold methods 
        public int countsurvey { get; set; }
        public int avargeAge { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public double pizzaPerc { get; set; }
        public double pastaPerc { get; set; }
        public double papnworsePerc { get; set; }

        ApplicationDbContext DB = new ApplicationDbContext();
        
        public int CountNosurveys()
        {
            int count = DB.Foods.Count();
            count +=1;   //counts no pple who took survey
            return count;
        }
       public int sum { get; set; }
        public int countsum()
        {
            
            return sum+=Age;
        }

        public int Avage()
        {
            // Food food = DB.Foods.Where(x=>x.Age>0).Single(); //Lambda
            //int Sumage = avargeAge; //food.Age;
           // Sumage+= countsum(); //getting sum of the Age
            int age = 0;
            age = countsum() / CountNosurveys();
            return age;
        }

        public int Maxage()
        {
            int max = MaxAge;
            if (Age == 0)
            {
                max = Age;
            }
            else 
            {
                if(Age> MaxAge)
                {
                    max = Age;
                }
                else 
                {
                    max = MaxAge;
                }
                
            }
            return max;
        }
        public int Minage()
        {
            int min = MinAge;
            if (Age == 0)
            {
                min = Age;
            }
            else
            {
                if (Age < min)
                {
                    min = Age;
                }
                else 
                {
                    min = MinAge;
                }

            }
            return min;
        }
        public double PizzaPec()
        {
            double pizza = 0.0;
            int count = 0;
            if(Pizza==true)
            {
                count += 1;
                pizza = (count / CountNosurveys())*100;
            }
            
            return pizza;
        }
        public double PastaPec()
        {
            double pasta = 0.0;
            int count = 0;
            if (Pasta == true)
            {
                count += 1;
                pasta = (count / CountNosurveys()) * 100;
            }

            return pasta;
        }
        public double PnWPec()
        {
            double pnwors = 0.0;
            int count = 0;
            if (PapWors == true)
            {
                count += 1;
                pnwors = (count / CountNosurveys()) * 100;
            }

            return pnwors;
        }
        public double Pepeatout()
        {
            int sa = 1;
            int a = 2;
            double pepeatout = 0.0;
            int count = 0;
            if (EatOut == "Strongly Agree")
            {
                count += sa;
                pepeatout = count / CountNosurveys();
            }
            else if(EatOut=="Agree")
            {
                count += a;
                pepeatout = count / CountNosurveys();
            }

            return pepeatout;
        }
        public double likewatchmvs()
        {
            int sa = 1;
            int a = 2;
            double likewatchmvs = 0.0;
            int count = 0;
            if (WatchMov == "Strongly Agree")
            {
                count += sa;
                likewatchmvs = count / CountNosurveys();
            }
            else if (WatchMov == "Agree")
            {
                count += a;
                likewatchmvs = count / CountNosurveys();
            }

            return likewatchmvs;
        }
        public double Watchtv()
        {
            int sa = 1;
            int a = 2;
            double watchtv = 0.0;
            int count = 0;
            if (WatchTv == "Strongly Agree")
            {
                count += sa;
                watchtv = count / CountNosurveys();
            }
            else if (WatchTv == "Agree")
            {
                count += a;
                watchtv = count / CountNosurveys();
            }

            return watchtv;
        }
        public double Listenradio()
        {
            int sa = 1;
            int a = 2;
            double listernradio = 0.0;
            int count = 0;
            if (LisRadio == "Strongly Agree")
            {
                count += sa;
                listernradio = count / CountNosurveys();
            }
            else if (LisRadio == "Agree")
            {
                count += a;
                listernradio = count / CountNosurveys();
            }

            return listernradio;
        }







    }
}