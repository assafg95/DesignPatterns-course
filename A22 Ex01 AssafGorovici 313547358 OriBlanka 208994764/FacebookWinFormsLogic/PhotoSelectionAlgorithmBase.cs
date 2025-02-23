﻿using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public abstract class PhotoSelectionAlgorithmBase
    {
        public Image GetPhoto(User i_FacebookUser)
        {
            FacebookObjectCollection<Photo> taggedPictures = i_FacebookUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            return GetImageFromAlbum(taggedPictures);
        }

        protected abstract Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album);
    }
}
