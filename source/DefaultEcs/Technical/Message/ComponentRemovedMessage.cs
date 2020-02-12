﻿namespace DefaultEcs.Technical.Message
{
    internal readonly struct ComponentRemovedMessage<T>
    {
        public readonly int EntityId;
        public readonly ComponentEnum Components;
        public readonly T OldValue;

        public ComponentRemovedMessage(int entityId, ComponentEnum components, in T oldValue)
        {
            EntityId = entityId;
            Components = components;
            OldValue = oldValue;
        }
    }
}
