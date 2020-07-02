# Class ColliderFollowerConfigurator

Sets up the ColliderFollower prefab based on the provided settings and implements the logic to follow the relevant source.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ColliderContainer]
  * [Facade]
  * [ObjectFollower]
  * [PositionExtractor]
* [Methods]
  * [OnEnable()]
  * [SetSource(GameObject)]
  * [SnapToSource()]

## Details

##### Inheritance

* System.Object
* ColliderFollowerConfigurator

##### Namespace

* [Tilia.Trackers.ColliderFollower]

##### Syntax

```
public class ColliderFollowerConfigurator : MonoBehaviour
```

### Properties

#### ColliderContainer

The GameObject containing the collider.

##### Declaration

```
public GameObject ColliderContainer { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public ColliderFollowerFacade Facade { get; protected set; }
```

#### ObjectFollower

The Zinnia.Tracking.Follow.ObjectFollower that performs the source follow.

##### Declaration

```
public ObjectFollower ObjectFollower { get; protected set; }
```

#### PositionExtractor

The TransformPositionExtractor that extracts the source position.

##### Declaration

```
public TransformPositionExtractor PositionExtractor { get; protected set; }
```

### Methods

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### SetSource(GameObject)

Sets the source on the relevant references.

##### Declaration

```
public virtual void SetSource(GameObject source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | source | The source to set. |

#### SnapToSource()

Snaps the tracked collider directly to the source current position.

##### Declaration

```
public virtual void SnapToSource()
```

[Tilia.Trackers.ColliderFollower]: README.md
[ColliderFollowerFacade]: ColliderFollowerFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ColliderContainer]: #ColliderContainer
[Facade]: #Facade
[ObjectFollower]: #ObjectFollower
[PositionExtractor]: #PositionExtractor
[Methods]: #Methods
[OnEnable()]: #OnEnable
[SetSource(GameObject)]: #SetSourceGameObject
[SnapToSource()]: #SnapToSource
