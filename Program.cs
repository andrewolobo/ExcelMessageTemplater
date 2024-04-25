using ClosedXML.Excel;
using System;


namespace SMSTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                string excelPath = @"C:\Users\olobo\Documents\DEV\SMSTEMP\SMSTemplate\Template.xlsx";
                SendSMS(excelPath);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }

        }

        static void SendSMS(string filepath){
            using(var workbook = new XLWorkbook(filepath))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach(var row in rows)
                {
                    if(row.RowNumber() == 1) continue; // Skip header row (assuming first row is header
                    string phoneNumber = row.Cell(1).Value.ToString();
                    string message = row.Cell(2).Value.ToString();
                    Console.WriteLine($"Sending SMS to {phoneNumber}...");
                    var result = FormatMessage(message, row);
                    Message(result);
                }
            }
        }

        static string FormatMessage(string template, IXLRangeRow row){
            string message = template;
            int dataColumnIndex = 3;

            for(int i = dataColumnIndex; i <= row.CellCount(); i++)
            {
                string placeholder = $"<{row.Worksheet.Cell(1, i).GetValue<string>()}>"; // Assuming first row has placeholder names
                string value = row.Cell(i).GetValue<string>();
                message = message.Replace(placeholder, value);

            }

            return message;
        }


        static void Message(string message)
        {
            Console.WriteLine(message);
        }

    }

}
