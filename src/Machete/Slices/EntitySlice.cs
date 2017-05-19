namespace Machete.Slices
{
    using System.Collections.Generic;


    public class EntitySlice<TEntity> :
        BaseEntitySlice
        where TEntity : Entity
    {
        readonly TEntity _entity;
        readonly ITextSliceProvider<TEntity>[] _sliceProviders;

        TextSlice[] _slices;
        bool _slicesComputed;

        public EntitySlice(TEntity entity, ITextSliceProvider<TEntity>[] sliceProviders)
            : base(ParseText.Empty)
        {
            _entity = entity;
            _sliceProviders = sliceProviders;
        }

        protected override TextSlice[] GetSlices()
        {
            if (_slicesComputed)
                return _slices;

            var slices = new List<TextSlice>(_sliceProviders.Length);
            for (int i = 0; i < _sliceProviders.Length; i++)
            {
                // TODO: Add Range of Fragments but don't use IEnumerable (use a Fragment Builder or something)
                slices.Add(_sliceProviders[i].GetSlice(_entity));
            }

            _slices = slices.ToArray();
            _slicesComputed = true;

            return _slices;
        }
    }
}