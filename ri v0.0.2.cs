using System;

namespace futuretech
{
    class randomints
    {
        static int Main(string[] args)
        {
            Console.WriteLine("���Ǳ�����ȷ���������");
            Console.WriteLine("�����������ݱ�ʶ��");
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
                    Console.WriteLine("��û���㹻�����Ȩ��");
                    Console.WriteLine("��ENTER���˳�");
                    Console.ReadLine();
                    return 0;
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
                        output = "������";
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
                int ѧ�� = new Random().Next(0, 59);
                Console.WriteLine("�뿼�Ժ�Ϊ180100" + ѧ�� + " ��ͬѧ�ش�");
                if(ѧ��==17)
                {
                    goto lable1;
                }
            }
            Console.ReadLine();
            return 0;
        }
    }
}
