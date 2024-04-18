using digiBookModel;
using System.Reflection;

namespace digiBookDataLayer
{
    public class Data
    {
        public static List<bookss> book ()
        {
            List<bookss> book = new List<bookss> ();

            bookss books1 = new bookss 
            {
                title = "THE ALCHEMIST",
                author = "Paulo Coelho\n",
                summary = "The Alchemist is a novel published in 1988 and written\n " +
                "by Brazilian author Paulo Coelho. The novel was originally published\n " +
                "in Portuguese but was later translated into other languages as it gained\n " +
                "popularity worldwide. There is also a short story within American\n " +
                "literature by the same name; however, The Alchemist short story was\n " +
                "written by American author H.P. Lovecraft and published in 1916.\n " +
                "Although some readers may think of Coelho's The Alchemist as a short\n " +
                "story, it is considered a novel because of the length of the work—nearly\n " +
                "200 pages. The novel is a modern classic that spans the genres of literary\n " +
                "fiction, fantasy fiction, and adventure fiction.What is the book\n " +
                "The Alchemist about? The main character is a Spanish shepherd boy named\n " +
                "Santiago who travels from his home in Andalusia to the pyramids in Egypt\n " +
                "in search of the treasure of his dreams and his own Personal Legend.\n " +
                "Throughout his journey across the Saharan Desert, Santiago meets several\n " +
                "characters who help guide him and give him advice. Santiago eventually\n " +
                "realizes that the treasure he seeks is not buried at the Egyptian pyramids\n " +
                "but in his very own hometown in Spain, where he then returns and finds the\n " +
                "hidden treasure."
            };
            book.Add (books1);

            bookss books2 = new bookss
            {
                title = "THE FOUR AGREEMENTS",
                author = "Miguel Ruiz\n",
                summary = "In The Four Agreements, don Miguel Ruiz reveals the source of\n" +
                " self-limiting beliefs that rob us of joy and create needless suffering.\n " +
                "Based on ancient Toltec wisdom, the Four Agreements offer a powerful code\n " +
                "of conduct that can rapidly transform our lives to a new experience of\n " +
                "freedom, true happiness, and love. The Four Agreements are: Be Impeccable\n " +
                "With Your Word, Don't Take Anything Personally, Don't Make Assumptions,\n " +
                "Always Do Your Best."
            };
            book.Add (books2);

            bookss books3 = new bookss
            {
                title = "THE SUBTLE ART OF NOT GIVING A FUCK",
                author = "Mark Manson",
                summary = "The Subtle Art of Not Giving a F*ck argues that individuals\n " +
                "should seek to find meaning through what they find to be important and\n " +
                "only engage in values that they can control. Values (such as popularity)\n " +
                "that are not under a person's control are, according to the book, 'bad\n " +
                "values'. Furthermore, individuals should strive to replace these\n " +
                "uncontrollable values with things they have the capability to change,\n " +
                "such as punctuality, honesty, or kindness. Manson further cautions against\n " +
                "claiming certainty about knowledge that is out of one's grasp, especially\n " +
                "in the case of attempting to leave a legacy. Meaning can be found, Manson\n " +
                "claims, when one seeks to create joy in the moment for one's self and\n " +
                "those around as opposed to being concerned with building a body of work\n " +
                "as a legacy."
            };
            book.Add (books3);

            bookss book4 = new bookss
            {
                title = "SURROUNDED BY IDIOT",
                author = "THOMAS ERIKSON",
                summary = "Effective communication is not a one-size-fits-all endeavor;\n " +
                "it requires adaptability to the listener's preferences and tendencies.\n " +
                "According to the DISA model, there are four core behavioral types, each\n " +
                "represented by a color: Red, Yellow, Green, and Blue. Adapting\n " +
                "communication styles to these types involves recognizing their\n " +
                "preferences: Reds prefer direct, respectful communication and autonomy;\n " +
                "Yellows thrive on friendliness and opportunities for innovation;\n " +
                "Greens seek recognition, gradual change, and moments to recharge;\n " +
                "Blues value accuracy, detail, and a focus on factual information.\n " +
                "However, navigating challenging combinations, such as Blue & Yellow and\n " +
                "Red & Green, requires finesse, as they represent behavioral opposites.\n " +
                "Furthermore, understanding the stress triggers and responses of each type\n " +
                "is crucial for effective communication in various contexts.\n"
            };
            book.Add (book4);

            bookss book5 = new bookss
            {
                title = "RICH DAD POOR DAD",
                author =  "Robert kiyosaki",
                summary = "The book is based on Kiyosaki's personal experiences with his\n " +
                "two fathers - his biological father (poor dad) and his best friend's\n " +
                "father (rich dad). The book provides a guide to financial literacy and\n " +
                "teaches readers about the importance of financial education, creating\n " +
                "wealth, and achieving financial freedom."
            };
            book.Add (book5);

            return book;
        } 
    }
}
