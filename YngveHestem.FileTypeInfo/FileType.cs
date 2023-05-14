using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace YngveHestem.FileTypeInfo
{
	public class FileType
	{
		/// <summary>
		/// A short description/name of the type.
		/// </summary>
		public string DescriptiveText { get; }

		/// <summary>
		/// The file extensions. This contains the dot at the start of each extension.
		/// </summary>
		public string[] Extensions { get; }

		/// <summary>
		/// The MIME-types.
		/// </summary>
		public string[] MimeTypes { get; }

		/// <summary>
		/// The UTType is the the UTI (Uniform Type Identifier).
		/// </summary>
		public string[] UTTypes { get; }

        /// <summary>
        /// Create a new type-entry.
        /// </summary>
        /// <param name="descriptiveText">A short description/name of the type.</param>
        /// <param name="extensions">The file extensions. This should contain the dot at the start of each extension.</param>
        /// <param name="mimeTypes">The MIME-types.</param>
        /// <param name="uTTypes">The UTType is the the UTI (Uniform Type Identifier).</param>
        public FileType(string descriptiveText, string[] extensions, string[] mimeTypes, string[] uTTypes)
		{
			DescriptiveText = descriptiveText;
			Extensions = extensions;
			UTTypes = uTTypes;
		}

        /// <summary>
        /// Return true if the inputted extension is one of the extensions in this type.
        /// </summary>
        /// <param name="extension">The extension to check for.</param>
        /// <returns></returns>
        public bool HasExtension(string extension)
        {
            return Extensions.Contains(extension);
        }

        /// <summary>
        /// Return true if at least one of the inputted extensions is one of the extensions in this type.
        /// </summary>
        /// <param name="extensions">The extensions to check if at least one of them is.</param>
        /// <returns></returns>
        public bool HasExtension(IEnumerable<string> extensions)
        {
            foreach(var extension in extensions)
            {
                if (Extensions.Contains(extension))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Return true if the inputted mime-type is one of the mime-types in this type.
        /// </summary>
        /// <param name="mimeType">The mime-type to check for.</param>
        /// <returns></returns>
        public bool HasMimeType(string mimeType)
        {
            return MimeTypes.Contains(mimeType);
        }

        /// <summary>
        /// Return true if at least one of the inputted mime-types is one of the mime-types in this type.
        /// </summary>
        /// <param name="mimeTypes">The mime-types to check if at least one of them is.</param>
        /// <returns></returns>
        public bool HasMimeType(IEnumerable<string> mimeTypes)
        {
            foreach (var mimeType in mimeTypes)
            {
                if (MimeTypes.Contains(mimeType))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Return true if the inputted UTType (UTI) is one of the UTTypes in this type.
        /// </summary>
        /// <param name="uTType">The UTI to check for.</param>
        /// <returns></returns>
        public bool HasUTType(string uTType)
        {
            return UTTypes.Contains(uTType);
        }

        /// <summary>
        /// Return true if at least one of the inputted UTTypes (UTI's) is one of the UTTypes in this type.
        /// </summary>
        /// <param name="mimeTypes">The mime-types to check if at least one of them is.</param>
        /// <returns></returns>
        public bool HasUTType(IEnumerable<string> uTTypes)
        {
            foreach (var uTType in uTTypes)
            {
                if (UTTypes.Contains(uTType))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(FileType b1, FileType b2)
        {
            if ((object)b1 == null)
                return (object)b2 == null;

            return b1.Equals(b2);
        }

        public static bool operator !=(FileType b1, FileType b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                FileType p = (FileType)obj;
                if (DescriptiveText != p.DescriptiveText || Extensions.Length != p.Extensions.Length || MimeTypes.Length != p.MimeTypes.Length || UTTypes.Length != p.UTTypes.Length)
				{
					return false;
				}

                for (var i = 0; i < Extensions.Length; i++)
                {
					if (Extensions[i] != p.Extensions[i])
					{
						return false;
					}
                }

                for (var i = 0; i < MimeTypes.Length; i++)
                {
                    if (MimeTypes[i] != p.MimeTypes[i])
                    {
                        return false;
                    }
                }

                for (var i = 0; i < UTTypes.Length; i++)
                {
                    if (UTTypes[i] != p.UTTypes[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + DescriptiveText.GetHashCode();
                hash = hash * 23 + Extensions.GetHashCode();
                hash = hash * 23 + MimeTypes.GetHashCode();
                hash = hash * 23 + UTTypes.GetHashCode();
                return hash;
            }
        }
    }
}

