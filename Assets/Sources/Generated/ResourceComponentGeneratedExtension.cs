namespace Entitas {
    public partial class Entity {
        public ResourceComponent resource { get { return (ResourceComponent)GetComponent(ComponentIds.Resource); } }

        public bool hasResource { get { return HasComponent(ComponentIds.Resource); } }

        public void AddResource(ResourceComponent component) {
            AddComponent(ComponentIds.Resource, component);
        }

        public void AddResource(string newName) {
            var component = new ResourceComponent();
            component.name = newName;
            AddResource(component);
        }

        public void ReplaceResource(ResourceComponent component) {
            ReplaceComponent(ComponentIds.Resource, component);
        }

        public void ReplaceResource(string newName) {
            ResourceComponent component;
            if (hasResource) {
                WillRemoveComponent(ComponentIds.Resource);
                component = resource;
            } else {
                component = new ResourceComponent();
            }
            component.name = newName;
            ReplaceResource(component);
        }

        public void RemoveResource() {
            RemoveComponent(ComponentIds.Resource);
        }
    }

    public static partial class Matcher {
        static AllOfEntityMatcher _matcherResource;

        public static AllOfEntityMatcher Resource {
            get {
                if (_matcherResource == null) {
                    _matcherResource = EntityMatcher.AllOf(new [] { ComponentIds.Resource });
                }

                return _matcherResource;
            }
        }
    }
}
