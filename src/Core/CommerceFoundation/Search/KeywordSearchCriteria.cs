﻿namespace VirtoCommerce.Foundation.Search
{
    using System;
    using System.Runtime.Serialization;

    public class KeywordSearchCriteria : SearchCriteriaBase
    {
        private string _SearchPhrase = String.Empty;

        /// <summary>
        /// Gets or sets the search phrase.
        /// </summary>
        /// <value>The search phrase.</value>
        [DataMember]
        public virtual string SearchPhrase
        {
            get { return _SearchPhrase; }
            set { ChangeState(); _SearchPhrase = value; }
        }

		/// <summary>
        /// Initializes a new instance of the <see cref="KeywordSearchCriteria"/> class.
		/// </summary>
		/// <param name="documentType">Type of the document.</param>
        public KeywordSearchCriteria(string documentType)
			: base(documentType)
		{

		}
    }
}
