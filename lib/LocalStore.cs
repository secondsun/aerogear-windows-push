/**
 * JBoss, Home of Professional Open Source
 * Copyright Red Hat, Inc., and individual contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * 	http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Windows.Storage;

namespace AeroGear.Push
{
    /// <summary>
    ///     Implementation of IChannelStore using LocalSettings
    /// </summary>
    public class LocalStore : ILocalStore
    {
        public void Save(string key, string value)
        {
            OpenSettings().Values[key] = value;
        }

        public string Read(string key)
        {
            return (string) OpenSettings().Values[key];
        }

        private ApplicationDataContainer OpenSettings()
        {
            return ApplicationData.Current.LocalSettings;
        }
    }
}