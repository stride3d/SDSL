# Parser and compiler for SDSL

This repository contains a new implementation of a parser/compiler for SDSL.

This implementation is described in detail in the [wiki](https://github.com/ykafia/SDSLParser/wiki).

## SDSL

[SDSL](https://doc.stride3d.net/latest/en/manual/graphics/effects-and-shaders/shading-language/index.html) is a shader language created for the [Stride game engine](https://www.stride3d.net/).

SDSL is a superset of the HLSL Shading language, bringing advanced and higher level language constructions, with:

* **extensibility** to allow shaders to be extended easily using object-oriented programming concepts such as classes, inheritance, and composition

* **modularity** to provide a set modular shaders each focusing on a single rendering technique, more easily manageable

* **reusability** to maximize code reuse between shaders