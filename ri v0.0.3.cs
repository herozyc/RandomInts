using System;

namespace futuretech
{
    class randomints
    {
        static int Main(string[] args)
        {
            Console.WriteLine("我们必须先确认您的身份");
            lable2:
            Console.WriteLine("请输入你的身份标识码,若以user登陆，请按ENTER");
            string id;
            string ot;
            id = Console.ReadLine();
           switch(id)
            {
                case "zxggxx2018":
                    ot = "admin";
                    break;
                case "exit":
                    return 0;
                    break;
                case "":
                    ot = "user";
                    break;
                default:
                    Console.WriteLine("您没有足够的浏览权限");
                    Console.WriteLine("按ENTER重试,输入exit退出");
                    string retry;
                    retry = Console.ReadLine();
                    if(retry=="exit")
                    {
                        return 0;
                    }
                    else
                    {
                        goto lable2;
                    }
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
                        output = "徐逍";
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
                int 学号 = new Random().Next(1, 59);
                
                if(学号==17)
                {
                    goto lable1;
                }
                else if(学号<10)
                {
                    string x;
                    x = "0";
                    Console.WriteLine("请考试号为180100" + x + 学号+ " 的同学回答");
                }
                else if(学号>=10)
                {
                    Console.WriteLine("请考试号为180100" + 学号 + " 的同学回答");
                }

            }
            Console.ReadLine();
            return 0;
        }
    }
}
/*
 * 下一步更新计划：
 * 1.字体放大
 * 2.GUI界面
 */
