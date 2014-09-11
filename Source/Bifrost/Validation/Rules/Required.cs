﻿#region License
//
// Copyright (c) 2008-2014, Dolittle (http://www.dolittle.com)
//
// Licensed under the MIT License (http://opensource.org/licenses/MIT)
//
// You may not use this file except in compliance with the License.
// You may obtain a copy of the license at 
//
//   http://github.com/dolittle/Bifrost/blob/master/MIT-LICENSE.txt
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
using System;
using Bifrost.Rules;

namespace Bifrost.Validation.Rules
{
    /// <summary>
    /// Represents the <see cref="ValueRule"/> for requiring the value
    /// </summary>
    public class Required : ValueRule
    {
        /// <summary>
        /// When a value is not specified, this is the reason given
        /// </summary>
        public static BrokenRuleReason ValueNotSpecified = BrokenRuleReason.Create("5F790FC3-5C7D-4F3A-B1E9-8F85FAF7176D");

#pragma warning disable 1591 // Xml Comments
        public override void Evaluate(IRuleContext context, object instance)
        {
            throw new System.NotImplementedException();
        }
#pragma warning restore 1591 // Xml Comments
    }
}
