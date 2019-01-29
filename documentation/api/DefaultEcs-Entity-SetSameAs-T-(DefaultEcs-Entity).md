#### [DefaultEcs](./DefaultEcs.md 'DefaultEcs')
### [DefaultEcs](./DefaultEcs.md#DefaultEcs 'DefaultEcs').[Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity')
## SetSameAs&lt;T&gt;(DefaultEcs.Entity) `method`
Sets the value of the component of type [T](#DefaultEcs-Entity-SetSameAs-T-(DefaultEcs-Entity)-T 'DefaultEcs.Entity.SetSameAs&lt;T&gt;(DefaultEcs.Entity).T') on the current Entity to the same instance of an other [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity').
### Type parameters

<a name='DefaultEcs-Entity-SetSameAs-T-(DefaultEcs-Entity)-T'></a>
`T`

The type of the component.
### Parameters

<a name='DefaultEcs-Entity-SetSameAs-T-(DefaultEcs-Entity)-reference'></a>
`reference`

The other [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') used as reference.
### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

[Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') was not created from a [World](./DefaultEcs-World.md 'DefaultEcs.World').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

Reference [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') comes from a different [World](./DefaultEcs-World.md 'DefaultEcs.World').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

Reference [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') does not have a component of type [T](#DefaultEcs-Entity-SetSameAs-T-(DefaultEcs-Entity)-T 'DefaultEcs.Entity.SetSameAs&lt;T&gt;(DefaultEcs.Entity).T').