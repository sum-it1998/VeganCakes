namespace Vegan_Cakes.Models
{
    public class FeedBackRepository : IFeedBackRepository
    {
        private readonly AppDbContext context;

        public FeedBackRepository(AppDbContext context)
        {
            this.context = context;
        }

        public FeedBack AddFeedBack(FeedBack feedBack)
        {
            context.FeedBacks.Add(feedBack);
            context.SaveChanges();
            return feedBack;

        }
    }
}
