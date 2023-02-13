
Console.WriteLine("[1] Display ticket list and information");
Console.WriteLine("[2] Create new ticket.");
Console.WriteLine("Enter other keys to exit.");

String? prompt = Console.ReadLine();

if (prompt == "1"){

    Console.WriteLine("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");
    if(System.IO.File.Exists("ticketData.csv")){
        StreamReader sr = new StreamReader("ticketData.csv");
        while(!sr.EndOfStream){
            string line = sr.ReadLine();
        }
    }
}
else if (prompt == "2"){
StreamWriter sw = new StreamWriter("ticketData.csv");

String[] tick = new String[7];

Console.WriteLine("Ticket #?");
tick[0] = Console.ReadLine();

Console.WriteLine("Summary?");
tick[1] = Console.ReadLine();

Console.WriteLine("Current Status?");
tick[2] = Console.ReadLine();

Console.WriteLine("What's the Priority?");
tick[3] = Console.ReadLine();

Console.WriteLine("Who is the Submitter?");
tick[4] = Console.ReadLine();

Console.WriteLine("Who is Assigned?");
tick[5] = Console.ReadLine();

Console.WriteLine("Who is watching?");
tick[6] = Console.ReadLine();

for(int i = 0; i < tick.Length; i++){
    
    sw.Write(tick[i] + ",");

    }
sw.Close();
 }
 

    


