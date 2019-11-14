#!/bin/bash

find . -type f -name '*.txt' | while read file; do
    cat "$file" >> input.txt
done

