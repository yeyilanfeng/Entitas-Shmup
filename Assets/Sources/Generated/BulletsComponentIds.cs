public static class BulletsComponentIds {
    public const int Destroy = 0;
    public const int Position = 1;
    public const int Resource = 2;
    public const int Velocity = 3;
    public const int View = 4;
    public const int Bullet = 5;

    public const int TotalComponents = 6;

    public static readonly string[] componentNames = {
        "Destroy",
        "Position",
        "Resource",
        "Velocity",
        "View",
        "Bullet"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(DestroyComponent),
        typeof(PositionComponent),
        typeof(ResourceComponent),
        typeof(VelocityComponent),
        typeof(ViewComponent),
        typeof(BulletComponent)
    };
}