﻿#region Copyright & License

// Copyright © 2012 - 2021 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace Be.Stateless.BizTalk.Unit.Xml.XPath.Extensions
{
	public static class XPathNodeIteratorExtensions
	{
		public static IEnumerable<XPathNavigator> Select(this XPathNodeIterator nodeIterator, string xpath)
		{
			return nodeIterator.Cast<XPathNavigator>().SelectMany(n => n.Select(xpath).Cast<XPathNavigator>());
		}
	}
}
