# Generated by Django 3.2.8 on 2021-10-27 03:35

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='AccessoryModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('type', models.IntegerField(choices=[(1, 'tuner'), (2, 'mediator'), (3, 'wire'), (4, 'belt')], default=1)),
                ('name', models.CharField(default='', max_length=40)),
                ('manufacturer', models.CharField(default='', max_length=50)),
                ('cost', models.FloatField(default=1, max_length=10)),
            ],
        ),
        migrations.CreateModel(
            name='EffectsModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=40)),
                ('effect', models.IntegerField(choices=[(1, 'processor'), (2, 'compressor'), (3, 'wah-wah'), (4, 'distortion'), (5, 'phaser'), (6, 'delay'), (7, 'reverb')], default=1)),
                ('cost', models.FloatField(default=1, max_length=10)),
            ],
        ),
        migrations.CreateModel(
            name='GuitarTypeModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.IntegerField(choices=[(1, 'electric'), (2, 'acoustic'), (3, 'bass')], default=1)),
            ],
        ),
        migrations.CreateModel(
            name='StringsModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=255)),
                ('number_of_strings', models.IntegerField(default=6, max_length=2)),
                ('caliber', models.IntegerField(default=8, max_length=3)),
                ('cost', models.FloatField(default=1, max_length=10)),
                ('guitar_type', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='labb.guitartypemodel')),
            ],
        ),
        migrations.CreateModel(
            name='GuitarsModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=255)),
                ('number_of_strings', models.IntegerField(default=6, max_length=2)),
                ('cost', models.FloatField(default=1, max_length=10)),
                ('type', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='labb.guitartypemodel')),
            ],
        ),
        migrations.CreateModel(
            name='ComboAmpsModel',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='', max_length=40)),
                ('power', models.IntegerField(default=10, max_length=3)),
                ('cost', models.FloatField(default=1, max_length=10)),
                ('guitar_type', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='labb.guitartypemodel')),
            ],
        ),
    ]
