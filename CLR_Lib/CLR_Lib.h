#pragma once

using namespace System;

namespace CLRLib {
	public ref class Class1
	{
	public:
		void Test()
		{
			Console::WriteLine("Hello from Class1");
			throw gcnew Exception("Test exception");
		}

		// TODO: Add your methods for this class here.
	};
}
