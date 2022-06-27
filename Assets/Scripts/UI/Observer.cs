

namespace Labirint
{
    public class Observer
    {
        private HpDelegate _hp;

        public void AddFunc(HpDelegate hp)
        {
            _hp += hp;
        }

        public void OnChanged()
        {
            _hp?.Invoke();
        }
    }

}
