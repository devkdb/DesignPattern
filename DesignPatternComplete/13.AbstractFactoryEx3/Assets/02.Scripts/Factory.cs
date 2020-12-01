using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race
{
    Terran,
    Protoss,
    Zerg
}

// 종족이 Terran이라면 모든 건물이 Terran용일 것이다.
// 이렇게 여러 종류의 객체를 생성할 때 객체들 사이의 관련성이 있는 경우라면
// 각 종류별로 별도의 Factory 클래스를 사용하는 대신
// 관련 객체들을 일관성 있게 생성하는 추상 팩토리 패턴을 적용하는 것이 편리하다.

public abstract class RaceFactory
{
    public abstract RaceCapacity makeCapacityBuilding();
    public abstract UnitBuilding makeUnitBuilding();
}

// 종족별로 Factory 클래스를 정의해 종족별 건물을 아주 간단히 생성할 수 있다.
// 즉, Terran 건물을 이용할 때는 TerranFactory객체를 생성할 수 있고
// Protoss 건물을 이용할 때는 ProtossFactory 객체를 생성할 수 있다.

public class TerranFactory : RaceFactory
{
    public override RaceCapacity makeCapacityBuilding()
    {
        return new SupplyDepot();
    }

    public override UnitBuilding makeUnitBuilding()
    {
        return new Barracks();
    }
}

public class ProtossFactory : RaceFactory
{
    public override RaceCapacity makeCapacityBuilding()
    {
        return new Pylon();
    }

    public override UnitBuilding makeUnitBuilding()
    {
        return new Gateway();
    }
}
