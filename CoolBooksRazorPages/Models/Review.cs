namespace CoolBooksRazorPages.Models
{
    public class Review//Uses reviews of different books
    {
        public int ReviewId { get; set; }//Id of the review
        public int UserId { get; set; }
        public string Title { get; set; }//Title of review Varchar255
        public string Text { get; set; }//Text content of the book Varchar 1000
        public int Rating { get; set; }//User rating of the book
        public bool IsDeleted { get; set; }//If the review is deleted or not.So admins can remove a review without deleting it
        public DateTime Created { get; set; }//Date review was created

        // Relations with other tables below
        public Book Book { get; set; }//The book the review is attached to
        public AspNetUser User { get; set; }//Id of the user so we know what user made the review, and what users can modify it
    }
}
