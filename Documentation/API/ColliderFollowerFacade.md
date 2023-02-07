# Class ColliderFollowerFacade

The public interface for the ColliderFollower prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [SnapOnEnable]
  * [Source]
* [Methods]
  * [ClearSource()]
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

#### SnapOnEnable

Whether to snap to source on enable.

##### Declaration

```
public bool SnapOnEnable { get; set; }
```

#### Source

The source to track.

##### Declaration

```
public GameObject Source { get; set; }
```

### Methods

#### ClearSource()

Clears [Source].

##### Declaration

```
public virtual void ClearSource()
```

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
[Source]: ColliderFollowerFacade.md#Source
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[SnapOnEnable]: #SnapOnEnable
[Source]: #Source
[Methods]: #Methods
[ClearSource()]: #ClearSource
[OnAfterSourceChange()]: #OnAfterSourceChange
[SnapToSource()]: #SnapToSource
