﻿// Copyright 2007-2015 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Scheduling
{
    /// <summary>
    /// If the scheduler is offline and comes back online, the policy determines how
    /// a missed scheduled message is handled.
    /// </summary>
    public enum MissedEventPolicy
    {
        /// <summary>
        /// use the default handling of the scheduler
        /// </summary>
        Default,

        /// <summary>
        /// Skip the event, waiting for the next scheduled interval
        /// </summary>
        Skip,

        /// <summary>
        /// Send the message immediately and then continue the schedule as planned
        /// </summary>
        Send
    }
}