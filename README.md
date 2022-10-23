# Generic Behaviors Playground



```mermaid
sequenceDiagram
    participant Entity
    participant Engine
    participant Behavior
    participant Criteria

    Entity->>+Engine: Abstract Factory
    Engine->>+Behavior: Processing
    Behavior->>+Criteria: Validation
    Criteria->>+Engine: Criterias match for behavior
    Engine->>+Behavior: Execution
```

Entities

Tick


IHM -> Fetch tick (TASK) -> Pass into Business Engine -> Fetch Behavior -> Log(N,nE) -> Match Criteria -> Engine return results


Scoped Task -> Business Engine -> 

Engine Result

If scope, apply any rule associated
If no scope, use criteria for dynamic trigger