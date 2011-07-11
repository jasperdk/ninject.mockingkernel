// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoqModule.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Remo Gloor remo.gloor@bbv.ch
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
//   Also licenced under Microsoft Public License (Ms-PL).
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ninject.MockingKernel.Moq
{
    using Ninject.Modules;

    /// <summary>
    /// The module for moq
    /// </summary>
    public class MoqModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            this.Kernel.Components.Add<IMockProviderCallbackProvider, MoqMockProvider>();
#if !SILVERLIGHT_30 && !SILVERLIGHT_20 && !NETCF
            this.Kernel.Components.Add<IMockRepositoryProvider, DefaultMockRepositoryProvider>();
#endif
        }
    }
}