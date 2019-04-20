using System;

namespace futuretech
{
    class randomints
    {
        static int Main(string[] args)
        {
            Console.WriteLine("我们必须先确认您的身份");
            Console.WriteLine("请输入你的身份标识码");
            string id;
            string ot;
            id = Console.ReadLine();
           switch(id)
            {
                case "zxggxx2018":
                    ot = "admin";
                    break;
                case "":
                    ot = "user";
                    break;
                default:
                    Console.WriteLine("您没有足够的浏览权限");
                    Console.WriteLine("按ENTER键退出");
                    Console.ReadLine();
                    return 0;
            }
            Console.WriteLine("欢迎," + ot);
            string input;
            string output;
            input = Console.ReadLine();
            if(ot=="admin")
            {
                switch(input)
                {
                    case "":
                        output = "陈柯睿";
                        break;
                    case "start":
                        output = "陈瑞权";
                        break;
                    case "begin":
                        output = "汪意林";
                        break;
                    default:
                        return 0;
                }
                Console.WriteLine("请" + output+"回答");
            }
            else if(ot=="user")
            {
                lable1:
                Console.ReadLine();
                int 学号 = new Random().Next(0, 59);
                Console.WriteLine("请考试号为180100" + 学号 + " 的同学回答");
                if(学号==17)
                {
                    goto lable1;
                }
            }
            Console.ReadLine();
            return 0;
        }
    }
}
