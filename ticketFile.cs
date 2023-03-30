public class ticketFile {

    public string filePath { get; set;}
    public List<Ticket> Tickets {get; set;}

    public ticketFile(string ticketFilePath){
        filePath = ticketFilePath;
        Tickets = new List<Ticket>();

        StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                Ticket ticket = new Ticket();
                string line = sr.ReadLine();
                
            }
    }

}