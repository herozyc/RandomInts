using System;

namespace futuretech
{
    class randomints
    {
        static int Main(string[] args)
        {
            Console.WriteLine("���Ǳ�����ȷ���������");
            lable2:
            Console.WriteLine("�����������ݱ�ʶ��,����user��½���밴ENTER");
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
                    Console.WriteLine("��û���㹻�����Ȩ��");
                    Console.WriteLine("��ENTER����,����exit�˳�");
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
            Console.WriteLine("��ӭ," + ot);
            string input;
            string output;
            input = Console.ReadLine();
            if(ot=="admin")
            {
                switch(input)
                {
                    case "":
                        output = "�¿��";
                        break;
                    case "start":
                        output = "����Ȩ";
                        break;
                    case "begin":
                        output = "����";
                        break;
                    default:
                        return 0;
                }
                Console.WriteLine("��" + output+"�ش�");
            }
            else if(ot=="user")
            {
                lable1:
                Console.ReadLine();
                int ѧ�� = new Random().Next(1, 59);
                
                if(ѧ��==17)
                {
                    goto lable1;
                }
                else if(ѧ��<10)
                {
                    string x;
                    x = "0";
                    Console.WriteLine("�뿼�Ժ�Ϊ180100" + x + ѧ��+ " ��ͬѧ�ش�");
                }
                else if(ѧ��>=10)
                {
                    Console.WriteLine("�뿼�Ժ�Ϊ180100" + ѧ�� + " ��ͬѧ�ش�");
                }

            }
            Console.ReadLine();
            return 0;
        }
    }
}
/*
 * ��һ�����¼ƻ���
 * 1.����Ŵ�
 * 2.GUI����
 */
