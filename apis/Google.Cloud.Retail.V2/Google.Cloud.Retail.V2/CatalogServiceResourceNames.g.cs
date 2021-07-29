// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagr = Google.Api.Gax.ResourceNames;

namespace Google.Cloud.Retail.V2
{
    public partial class ListCatalogsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SetDefaultBranchRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Catalog"/> resource name property.
        /// </summary>
        public CatalogName CatalogAsCatalogName
        {
            get => string.IsNullOrEmpty(Catalog) ? null : CatalogName.Parse(Catalog, allowUnparsed: true);
            set => Catalog = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BranchName"/>-typed view over the <see cref="BranchId"/> resource name property.
        /// </summary>
        public BranchName BranchIdAsBranchName
        {
            get => string.IsNullOrEmpty(BranchId) ? null : BranchName.Parse(BranchId, allowUnparsed: true);
            set => BranchId = value?.ToString() ?? "";
        }
    }

    public partial class GetDefaultBranchRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Catalog"/> resource name property.
        /// </summary>
        public CatalogName CatalogAsCatalogName
        {
            get => string.IsNullOrEmpty(Catalog) ? null : CatalogName.Parse(Catalog, allowUnparsed: true);
            set => Catalog = value?.ToString() ?? "";
        }
    }

    public partial class GetDefaultBranchResponse
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Branch"/> resource name property.</summary>
        public BranchName BranchAsBranchName
        {
            get => string.IsNullOrEmpty(Branch) ? null : BranchName.Parse(Branch, allowUnparsed: true);
            set => Branch = value?.ToString() ?? "";
        }
    }
}
