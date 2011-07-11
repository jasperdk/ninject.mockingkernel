//-------------------------------------------------------------------------------
// <copyright file="IMockRepositoryProvider.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

#if !SILVERLIGHT_30 && !SILVERLIGHT_20 && !NETCF
namespace Ninject.MockingKernel.Moq
{
    using System.Reflection;
    using global::Moq;
    using Ninject.Components;

    /// <summary>
    /// Provider for the MockRepository used to create new mock instances.
    /// </summary>
    public interface IMockRepositoryProvider : INinjectComponent
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        MockRepository Instance { get; }

        /// <summary>
        /// Gets the method info of the create method.
        /// </summary>
        /// <value>The method info of the create method.</value>
        MethodInfo CreateMethod { get; }
    }
}
#endif