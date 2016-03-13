//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        static readonly BulletComponent bulletComponent = new BulletComponent();

        public bool isBullet {
            get { return HasComponent(BulletsComponentIds.Bullet); }
            set {
                if (value != isBullet) {
                    if (value) {
                        AddComponent(BulletsComponentIds.Bullet, bulletComponent);
                    } else {
                        RemoveComponent(BulletsComponentIds.Bullet);
                    }
                }
            }
        }

        public Entity IsBullet(bool value) {
            isBullet = value;
            return this;
        }
    }
}

    public partial class BulletsMatcher {
        static IMatcher _matcherBullet;

        public static IMatcher Bullet {
            get {
                if (_matcherBullet == null) {
                    var matcher = (Matcher)Matcher.AllOf(BulletsComponentIds.Bullet);
                    matcher.componentNames = BulletsComponentIds.componentNames;
                    _matcherBullet = matcher;
                }

                return _matcherBullet;
            }
        }
    }
