﻿namespace Strategy
{
    public class ImageStorage
    {

        //private readonly ICompressor _compressor;
        //private readonly IFilter _filter;

        //public ImageStorage(ICompressor compressor, IFilter filter)
        //{
        //    _compressor = compressor;
        //    _filter = filter;
        //}

        public void Store(string fileName, ICompressor compressor,IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}