# -*- coding: utf-8 -*-
"""
Created on Sun Dec 18 07:47:46 2022

@author: Tatiana Chiapco
"""

class Conversion_Calc_Meter:
    
    #Decameter
    
    def convert_to_decameter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10**1
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) / 10**3
            return value_1
            
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**4
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**7
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**9
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) / 10
            return value_1
            
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**1
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**2
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**5
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**8
            return value_1
        
    # Hectometer
    def convert_to_hectometer(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10**2
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**4
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**8
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**11
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) / 100
        
        elif current_unit == "decameter":
            value_1 = float(value) / 10**1
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**4
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**7
            return value_1
            
    # Meter
    def convert_to_meter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) / 10**2
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**3
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**6
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**9
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 10
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**2
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**6
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**9
            return value_1
    
    # Kilometer
    def convert_to_kilometer(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10**4
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) / 10**5
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**6
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**9
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**12
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) / 100
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) / 10
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**6
            return value_1
            
    # Megameter
    def convert_to_megameter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10**7
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) / 10**8
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**9
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**12
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**15
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) / 10**5
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) / 10**4
            return value_1
            
        elif current_unit == "meter":
            value_1 = float(value) / 10**6
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) / 10**3
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**3
            return value_1

 # Gigameter
            
    def convert_to_gigameter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) / 10**10
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) / 10**11
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**12
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**15
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**18
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) / 10**8
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) / 10**7
            return value_1
            
        elif current_unit == "meter":
            value_1 = float(value) / 10**9
            return value_1
        
        elif current_unit == "kilometer":
            value_1= float(value) / 10**6
            return value_1
        
        elif current_unit == "megameter":
            value_1= float(value) / 10**3
            return value_1
    
    ############
    
    
    # Decimeter
    def convert_to_decimeters(current_unit, value): 
        if current_unit == "centimeter":
            value_1 = float(value) / 10
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10**2
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**5
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**8
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 100
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) * 10
            return value_1
        
        elif current_unit == "kilometer":
            value_1= float(value) * 10**4
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**7
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**10
            return value_1
    
    # Centimeter
    def convert_to_centimeter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) * 10
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) / 10
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**4
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**7
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**4
            return value_1
            
        elif current_unit == "meter":
            value_1 = float(value) * 10**2
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**5
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**8
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**11
            return value_1
    
    # Millimeter
    def convert_to_millimeter(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) * 10**2
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) * 10
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) / 10**3
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**6
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 10**4
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**5
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**6
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**9
            return value_1
        
        elif current_unit == "gigameter":
            value_1= float(value) * 10**12
            return value_1
        
    # Micrometer
    def convert_to_micrometer(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) * 10**5
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) * 10**4
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "nanometer":
            value_1 = float(value) / 10**3
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 10**7
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**8
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) * 10**6
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**9
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**12
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**15
            return value_1
    # Nanometer
    def convert_to_nanometer(current_unit, value):
        if current_unit == "decimeter":
            value_1 = float(value) * 10**8
            return value_1
        
        elif current_unit == "centimeter":
            value_1 = float(value) * 10**7
            return value_1
        
        elif current_unit == "millimeter":
            value_1 = float(value) * 10**6
            return value_1
        
        elif current_unit == "micrometer":
            value_1 = float(value) * 10**3
            return value_1
        
        elif current_unit == "decameter":
            value_1 = float(value) * 10**10
            return value_1
        
        elif current_unit == "hectometer":
            value_1 = float(value) * 10**11
            return value_1
        
        elif current_unit == "meter":
            value_1 = float(value) * 10**9
            return value_1
        
        elif current_unit == "kilometer":
            value_1 = float(value) * 10**12
            return value_1
        
        elif current_unit == "megameter":
            value_1 = float(value) * 10**15
            return value_1
        
        elif current_unit == "gigameter":
            value_1 = float(value) * 10**18
            return value_1