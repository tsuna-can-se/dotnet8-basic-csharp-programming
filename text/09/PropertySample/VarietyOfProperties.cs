namespace PropertySample;

public class VarietyOfProperties
{
    public int HasPublicSetter { get; set; }
    public int HasPrivateSetter { get; private set; }
    public int NoSetter { get; }
    public int HasPublicInit { get; init; }
    public int HasPrivateInit { get; private init; }

    public VarietyOfProperties()
    {
        // コンストラクター内
        this.HasPublicSetter = 1;
        this.HasPrivateSetter = 1;
        this.NoSetter = 1;
        this.HasPublicInit = 1;
        this.HasPrivateInit = 1;
    }

    public void SetValueInSameClassMethod()
    {
        // コンストラクターを除く自クラス内
        this.HasPublicSetter = 2;
        this.HasPrivateSetter = 2;
        // this.NoSetter = 2;       // セッターがないためコンストラクター以外では値を設定できない
        // this.HasPublicInit = 2;  // init の場合コンストラクターとオブジェクト初期化子以外では値を設定できない
        // this.HasPrivateInit = 2; // init の場合コンストラクターとオブジェクト初期化子以外では値を設定できない
    }
}

public class UseProperties
{
    public void ObjectInitializer()
    {
        // オブジェクト初期化子
        var obj = new VarietyOfProperties()
        {
            HasPublicSetter = 3,
            // HasPrivateSetter = 3, // private メンバーにはクラス外からアクセスできない
            // NoSetter = 3,         // セッターがないためコンストラクター以外では値を設定できない
            HasPublicInit = 3,
            // HasPrivateInit = 3,   // private メンバーにはクラス外からアクセスできない
        };
    }

    public void CallSetter()
    {
        // 他クラスからの設定
        var obj = new VarietyOfProperties();
        obj.HasPublicSetter = 4;
        // obj.HasPrivateSetter = 4; // private メンバーにはクラス外からアクセスできない
        // obj.NoSetter = 4;         // セッターがないためコンストラクター以外では値を設定できない
        // obj.HasPublicInit = 4;    // init の場合コンストラクターとオブジェクト初期化子以外では値を設定できない
        // obj.HasPrivateInit = 4;   // init の場合コンストラクターとオブジェクト初期化子以外では値を設定できない
    }
}
