using System;

namespace AuditIssue.Entities
{
    public abstract class Request
    {
        public Guid Id { get; }
        public string UserId { get; }

        protected Request() { }

        internal Request(string userId)
        {
            UserId = userId;
        }
    }
}
