namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        
        public ITrackable Parse(string line)
        {
            if (line == null)
            {
                return null;
            }
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');
            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError(null);
                return null;
            }

            Point coords = new Point();
            TacoBell restaurant = new TacoBell();
            
            coords.Latitude = double.Parse(cells[0]);
            coords.Longitude = double.Parse(cells[1]);
            restaurant.Location = coords;
            

            restaurant.Name = cells[2];
            return restaurant;
        }
    }

    
}