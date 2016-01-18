using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg___
{
    class Program
    {

        // ABC  PQRST > PRTSS
       static StringBuilder TempMessage = new StringBuilder();
       static StringBuilder Encode = new StringBuilder();

        static void CypherFirst(string Message, string Cypher)
        {

            int StartIndex = 0 + Message.Length;
            int EndIndex = 0;

            string Cypher2 = Cypher;

            for (int i = 0; i < Message.Length; i++)
            {

                int message_code = Message[i] - 65;

                if (i < Cypher2.Length)
                {
                int cypher_code = Cypher2[i] - 65;

                TempMessage.Append(Convert.ToChar((message_code ^ cypher_code) + 65));
                }

                else
                {
                    TempMessage.Append(Convert.ToChar(message_code + 65));

                }

                if (i == Message.Length - 1)
                {
                    if (Cypher2.Length < Cypher.Length)
                    {

                        break;
                    }
                    if (Cypher2.Length >= TempMessage.ToString().Length)
                    {

                        if ((Cypher2.Length - Message.Length) < Message.Length)
                        {
                            EndIndex = Cypher2.Length - Message.Length;

                        }
                        else
                        {
                            EndIndex = Message.Length;

                        }


                        Cypher2 = Cypher.Substring(StartIndex, EndIndex);
                        Message = TempMessage.ToString();
                        TempMessage.Clear();
                        i = -1;
                        StartIndex += Message.Length;

                    }
                    else
                    {

                        EndIndex = Cypher2.Length - Message.Length;
                        Cypher2 = Cypher.Substring(StartIndex, EndIndex);
                        Message = TempMessage.ToString();

                        i = -1;

                    }


                }
            }

        }



        static void EncodeString(string input)
        {


            char match = input[0];
            int counter_match = 0;

            for (int i = 0; i < input.Length; i++)
            {


                if (i == input.Length - 1 && match != input[i])
                {
                    if (counter_match > 2)
                    {
                        Encode.Append(counter_match);
                    }
                    else if (counter_match == 2 )
                    {
                        Encode.Append(match);
                        Encode.Append(match);
                        Encode.Append(input[i]);
                        continue;

                    }
                    Encode.Append(match);
                    Encode.Append(input[i]);
                    continue;
                }


                if (match == input[i])
                {
                    counter_match++;
                    if (i == input.Length - 1)
                    {
                        if (counter_match == 2)
                        {
                            Encode.Append(match);
                            Encode.Append(match);

                        }
                        else
                        {
                            if (counter_match > 1)
                            {
                                Encode.Append(counter_match);
                            }
                            Encode.Append(match);
                        }

                    }

                }


                else
                {

                    if (counter_match == 2)
                    {
                        Encode.Append(match);
                        Encode.Append(match);
                        counter_match = 1;
                        match = input[i];

                    }

                    else
                    {
                        if (counter_match > 1)
                        {
                            Encode.Append(counter_match);
                        }
                        Encode.Append(match);

                        match = input[i];
                        counter_match = 1;
                    }
                }


            }

        }

        static void MessageFirst(string Message, string Cypher)
        {

            int CypherLenght = 0;
            for (int i = 0; i < Message.Length; i++)
            {
                int message_code = Message[i] - 65;
                int cypher_code = Cypher[CypherLenght] - 65;
                TempMessage.Append(Convert.ToChar((message_code ^ cypher_code) + 65));

                CypherLenght++;
                if (CypherLenght == Cypher.Length)
                {
                    CypherLenght = 0;
                }


            }

        }

        static void Main()
        {

            string Message = Console.ReadLine();
            string Cypher = Console.ReadLine();

            if (Message.Length >= Cypher.Length)
            {
                MessageFirst(Message, Cypher);
            }
            if (Message.Length < Cypher.Length)
            {
                CypherFirst(Message, Cypher);

            }
          
            EncodeString(TempMessage.Append(Cypher).ToString());
            Console.WriteLine(Encode.Append(Cypher.Length));
  

        }
    }
}