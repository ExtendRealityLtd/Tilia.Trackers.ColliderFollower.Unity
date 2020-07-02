# Class ColliderFollowerFacade

The public interface for the ColliderFollower prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [Source]
* [Methods]
  * [OnAfterSourceChange()]
  * [SnapToSource()]

## Details

##### Inheritance

* System.Object
* ColliderFollowerFacade

##### Namespace

* [Tilia.Trackers.ColliderFollower]

##### Syntax

```
public class ColliderFollowerFacade : MonoBehaviour
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public ColliderFollowerConfigurator Configuration { get; protected set; }
```

#### Source

The source to track.

##### Declaration

```
public GameObject Source { get; set; }
```

### Methods

#### OnAfterSourceChange()

Called after [Source] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceChange()
```

#### SnapToSource()

Snaps the tracked collider directly to the source current position.

##### Declaration

```
public virtual void SnapToSource()
```

[Tilia.Trackers.ColliderFollower]: README.md
[ColliderFollowerConfigurator]: ColliderFollowerConfigurator.md
[Source]: ColliderFollowerFacade.md#Source
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[Source]: #Source
[Methods]: #Methods
[OnAfterSourceChange()]: #OnAfterSourceChange
[SnapToSource()]: #SnapToSource
