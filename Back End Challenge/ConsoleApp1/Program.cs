using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int chunkSize = 80;

			string text = System.IO.File.ReadAllText(@"D:\Projects\ConsoleApp1\text.txt");

			//split into paragraphs
			var paragraphs = text.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None).ToList();

			foreach(string paragraph in paragraphs)
			{
				var paragraphWords = paragraph.Split(new string[] { "\r\n", " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

				while (paragraphWords.Count > 0)
				{
					string currentLine = "";

					while (true)
					{
						if (paragraphWords.Count > 0)
						{
							string currentWord = paragraphWords[0];
							var temp = currentLine + ' ' + currentWord;
							if (temp.Length <= chunkSize)
							{
								paragraphWords.RemoveAt(0);
								currentLine = temp;
							}
							else
							{
								Console.WriteLine(currentLine);
								break;
							}
						}
						else
						{
							Console.WriteLine(currentLine);
							break;
						}
					}
					
				}

				Console.Write(System.Environment.NewLine);
			}
			
			Console.ReadLine();
		}
	}
}
