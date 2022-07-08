using BlueSquareBugTracker.Data;
using BlueSquareBugTracker.Data.Entities;

namespace BlueSquareBugTracker.Core.Session
{
    public class SessionManager
    {
        protected readonly AppDbContext DbContext;
        protected User Current { get; set; }
        
        public SessionManager(AppDbContext dbContext, IHttpContextAccessor httpContext, IWebHostEnvironment env)
        {
            DbContext = dbContext;
            long? UserId = httpContext.HttpContext.Session.GetInt32("UserId");
            if (env.IsDevelopment())
                Current = DbContext.User.FirstOrDefault(x => x.Id == 2);
            else if (UserId.HasValue)
                Current = DbContext.User.FirstOrDefault(x => x.Id == UserId);
        }
        public bool AuthenticatedUser()
        {
            return Current != null;
        }
        public long? GetCurrentUserId()
        {
            return Current?.Id;
        }
        
    }
}
