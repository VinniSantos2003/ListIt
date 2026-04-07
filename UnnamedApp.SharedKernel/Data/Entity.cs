using System;
using System.Collections.Generic;
using System.Text;
using UnnamedApp.SharedKernel.Enum;

namespace UnnamedApp.SharedKernel.Data
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.CreateVersion7();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public State State { get; set; } = State.Active;

        public void UpdateTimestamps()
        {
            UpdatedAt = DateTime.UtcNow;
        }
        public void Disable()
        {
            State = State.Inactive;
            UpdateTimestamps();
        }
        public void Enable()
        {
            State = State.Active;
            UpdateTimestamps();
        }
        public void Delete()
        {
            State = State.Deleted;
            UpdateTimestamps();
        }
    }
}
