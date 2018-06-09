﻿using System;
using DefaultBrick.Component;
using DefaultBrick.Message;
using DefaultEcs;
using DefaultEcs.System;

namespace DefaultBrick.System
{
    public sealed class BallBoundSystem : AEntitySetSystem<float>
    {
        private readonly World _world;

        public BallBoundSystem(World world)
            : base(world.GetEntities().With<Velocity>().With<Position>().With<Ball>().Build())
        {
            _world = world;
        }

        protected override void Update(float elaspedTime, ReadOnlySpan<Entity> entities)
        {
            Span<Entity> entityCopies = stackalloc Entity[entities.Length];
            entities.CopyTo(entityCopies);

            foreach (Entity entity in entityCopies)
            {
                ref Position position = ref entity.Get<Position>();
                ref Velocity velocity = ref entity.Get<Velocity>();

                if (position.Value.X < 0)
                {
                    position.Value.X *= -1;
                    velocity.Value.X *= -1;
                }
                else if (position.Value.X > 790)
                {
                    position.Value.X = 1580 - position.Value.X;
                    velocity.Value.X *= -1;
                }

                if (position.Value.Y < 0)
                {
                    position.Value.Y *= -1;
                    velocity.Value.Y *= -1;
                }
                else if (position.Value.Y > 600)
                {
                    entity.Dispose();
                    _world.Publish<BallDroppedMessage>(default);
                }
            }
        }
    }
}