using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Todo.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {

        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

        public bool Equals([AllowNull] Entity other)
        {
            return Id == other.Id;
        }
    }
}
