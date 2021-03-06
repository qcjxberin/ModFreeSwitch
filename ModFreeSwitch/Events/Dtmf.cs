/*
    Copyright [2016] [Arsene Tochemey GANDOTE]

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using ModFreeSwitch.Messages;

namespace ModFreeSwitch.Events {
    public class Dtmf : EslEvent {
        public Dtmf(EslMessage message) : base(message) {}

        public char Digit => Convert.ToChar(this["DTMF-Digit"]);

        public int Duration {
            get {
                int duration;
                return int.TryParse(this["DTMF-Duration"], out duration) ? duration : 0;
            }
        }

        public override string ToString() {
            return "Dtmf(" + Digit + ").";
        }
    }
}
