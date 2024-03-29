using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace NaInSec_Virus.My;

[DebuggerNonUserCode]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal sealed class InternalXmlHelper
{
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private sealed class RemoveNamespaceAttributesClosure
	{
		private readonly string[] m_inScopePrefixes;

		private readonly XNamespace[] m_inScopeNs;

		private readonly List<XAttribute> m_attributes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
		{
			m_inScopePrefixes = inScopePrefixes;
			m_inScopeNs = inScopeNs;
			m_attributes = attributes;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement ProcessXElement(XElement elem)
		{
			return RemoveNamespaceAttributes(m_inScopePrefixes, m_inScopeNs, m_attributes, elem);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object ProcessObject(object obj)
		{
			XElement val = (XElement)((obj is XElement) ? obj : null);
			if (val != null)
			{
				return RemoveNamespaceAttributes(m_inScopePrefixes, m_inScopeNs, m_attributes, val);
			}
			return obj;
		}
	}

	public static string Value
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return current.Value;
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.Value = value;
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return (string)current.Attribute(name);
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.SetAttributeValue(name, (object)value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			return (string)source.Attribute(name);
		}
		set
		{
			source.SetAttributeValue(name, (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private InternalXmlHelper()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateAttribute(XName name, object value)
	{

		if (value == null)
		{
			return null;
		}
		return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
	{

		XAttribute val = new XAttribute(name, (object)ns.NamespaceName);
		((XObject)val).AddAnnotation((object)ns);
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
	{
		if (obj != null)
		{
			XElement val = (XElement)((obj is XElement) ? obj : null);
			if (val != null)
			{
				return RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, val);
			}
			if (obj is IEnumerable obj2)
			{
				return RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, obj2);
			}
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
	{
		if (obj != null)
		{
			if (obj is IEnumerable<XElement> source)
			{
				return source.Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement);
			}
			return obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject);
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
	{
		checked
		{
			if (e != null)
			{
				XAttribute val = e.FirstAttribute;
				while (val != null)
				{
					XAttribute nextAttribute = val.NextAttribute;
					if (val.IsNamespaceDeclaration)
					{
						XNamespace val2 = ((XObject)val).Annotation<XNamespace>();
						string localName = val.Name.LocalName;
						if (val2 != null)
						{
							if ((inScopePrefixes != null && inScopeNs != null) ? true : false)
							{
								int num = inScopePrefixes.Length - 1;
								int num2 = num;
								int num3 = 0;
								while (true)
								{
									int num4 = num3;
									int num5 = num2;
									if (num4 > num5)
									{
										break;
									}
									string value = inScopePrefixes[num3];
									XNamespace val3 = inScopeNs[num3];
									if (localName.Equals(value))
									{
										if (val2 == val3)
										{
											val.Remove();
										}
										val = null;
										break;
									}
									num3++;
								}
							}
							if (val != null)
							{
								if (attributes != null)
								{
									int num6 = attributes.Count - 1;
									int num7 = num6;
									int num8 = 0;
									while (true)
									{
										int num9 = num8;
										int num5 = num7;
										if (num9 > num5)
										{
											break;
										}
										XAttribute val4 = attributes[num8];
										string localName2 = val4.Name.LocalName;
										XNamespace val5 = ((XObject)val4).Annotation<XNamespace>();
										if (val5 != null && localName.Equals(localName2))
										{
											if (val2 == val5)
											{
												val.Remove();
											}
											val = null;
											break;
										}
										num8++;
									}
								}
								if (val != null)
								{
									val.Remove();
									attributes.Add(val);
								}
							}
						}
					}
					val = nextAttribute;
				}
			}
			return e;
		}
	}
}
